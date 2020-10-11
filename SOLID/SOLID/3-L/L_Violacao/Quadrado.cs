using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._3_L.L_Violacao
{
    public class Quadrado : Retangulo
    {
        // Classe filha esta violando comportamento da classe pai ao ser instanciada para descobrir valor do Retangulo.
        public override double Altura
        {
            set { base.Altura = base.Largura = value; }
        }

        public override double Largura
        {
            set { base.Altura = base.Largura = value; }
        }
    }
}
