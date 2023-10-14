
using DesignPatterns.PatternsCriational.Builder.Exemplo_1.Studios;

namespace DesignPatterns.PatternsCriational.Builder.Exemplo_1.Builders
{
    public class Studio28mBuilder : StudioBuilder
    {
        public Studio28mBuilder()
        {
            Studio = new Studio28m();
        }

        public override void DefinirValorStudio()
        {
            Studio.DefinirValorStudio(200000.00M);
        }

        public override void EscolherFinaciamento()
        {
            Studio.EscolherFinanciamento("Intuitiva Financiamentos");
        }

        public override void EscolherPiso()
        {
            Studio.EscolherPiso("Piso vinílico");
        }
    }
}
