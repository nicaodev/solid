using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._1_S.S_Solucao
{
    public static class CPFServices
    {
        public static bool IsValid(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}
