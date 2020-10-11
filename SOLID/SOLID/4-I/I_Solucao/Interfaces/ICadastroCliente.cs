using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._4_I.I_Solucao.Interfaces
{
    public interface ICadastroCliente
    {
        void ValidarDados();
        void SalvarBanco();
        void EnviarEmail();
    }
}
