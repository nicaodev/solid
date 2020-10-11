using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace SOLID._1_S.S_Violacao
{
    /* A Classe cliente não precisa saber como se valida o e-mail, cpf. Como salvar o cadastro no banco e nem como enviar e-mail. Isso tudo são responsabilidades a mais para 1 classe.
     * Ferindo o primeiro princípio que diz que, a classe deve ser mudada apenas por um motivo, aqui, vemos 4.
     */
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }

        public string AdicionarCliente()
        {
            if (!Email.Contains("@"))
                return "Cliente com e-mail inválido";

            if (CPF.Length != 11)
                return "Cliente com CPF inválido";


            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "Server=localhost;Database=SOLID;User Id=root;Password=1597535;";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CLIENTE (NOME, EMAIL CPF, DATACADASTRO) VALUES (@nome, @email, @cpf, @dataCad))";

                cmd.Parameters.AddWithValue("nome", Nome);
                cmd.Parameters.AddWithValue("email", Email);
                cmd.Parameters.AddWithValue("cpf", CPF);
                cmd.Parameters.AddWithValue("dataCad", DataCadastro);

                cn.Open();
                cmd.ExecuteNonQuery();
            }

            var mail = new MailMessage("empresa@empresa.com", Email);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = $"{Nome}, seja Bem-Vindo.";
            mail.Body = "Parabéns! Cadastro realizado com sucesso!";
            client.Send(mail);

            return "Cliente cadastrado com sucesso!";
        }
    }
}