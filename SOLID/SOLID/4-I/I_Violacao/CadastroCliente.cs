using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._4_I.I_Violacao
{
    public class CadastroCliente : ICadastro
    {
        public void ValidarDados()
        {
            // Validar CPF, Email
        }

        public void SalvarBanco()
        {
            // Insert na tabela Cliente
        }

        public void EnviarEmail()
        {
            // Enviar e-mail para o cliente
        }
    }
}
