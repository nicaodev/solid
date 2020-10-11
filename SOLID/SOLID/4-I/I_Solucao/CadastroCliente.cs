using SOLID._4_I.I_Solucao.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._4_I.I_Solucao
{
    public class CadastroCliente : ICadastroCliente
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
