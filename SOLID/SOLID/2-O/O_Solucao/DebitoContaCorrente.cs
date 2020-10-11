using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._2_O.O_Solucao
{
    public class DebitoContaCorrente : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            // Lógica de Debitar em Conta Corrente
            return FormatarTransacao();
        }
    }
}
