﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._4_I.I_Violacao
{
    public class CadastroProduto : ICadastro
    {
        public void ValidarDados()
        {
            // Validar valor
        }

        public void SalvarBanco()
        {
            // Insert tabela Produto
        }

        public void EnviarEmail()
        {
            // Produto não tem e-mail, o que eu faço agora???
            throw new NotImplementedException("Esse metodo não serve pra nada");
        }
    }
}
