using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriational.Builder.Exemplo_1.Studios
{
    public abstract class Studio
    {
        public string TipoPiso { get; protected set; }
        public string TipoFinanciamento { get; protected set; }
        public decimal Valor { get; protected set; }

        public abstract void EscolherPiso(string piso);
        public abstract void EscolherFinanciamento(string financiamento);
        public abstract void DefinirValorStudio(decimal valor);
    }
}
