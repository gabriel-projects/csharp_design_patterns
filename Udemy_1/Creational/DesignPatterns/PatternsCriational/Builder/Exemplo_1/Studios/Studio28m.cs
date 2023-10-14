using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriational.Builder.Exemplo_1.Studios
{
    public class Studio28m : Studio
    {
        public override void DefinirValorStudio(decimal valor)
        {
            Valor = valor;
        }

        public override void EscolherFinanciamento(string financiamento)
        {
            TipoFinanciamento = financiamento;
        }

        public override void EscolherPiso(string piso)
        {
            TipoPiso = piso;
        }
    }
}
