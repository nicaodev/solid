using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._4_I.I_Violacao
{
    public interface ICadastro
    {
        void ValidarDados();
        void SalvarBanco();
        void EnviarEmail();
    }
}
