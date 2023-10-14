using DesignPatterns.PatternsCriational.Builder.Exemplo_1.Studios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriational.Builder.Exemplo_1.Builders
{
    public class Studio24mBuilder : StudioBuilder
    {
        public Studio24mBuilder()
        {
            Studio = new Studio24m();
        }

        public override void DefinirValorStudio()
        {
            Studio.DefinirValorStudio(180000.00M);
        }

        public override void EscolherFinaciamento()
        {
            Studio.EscolherFinanciamento("Finainvestimentos");
        }

        public override void EscolherPiso()
        {
            Studio.EscolherPiso("Cerâmica");
        }
    }
}
