using DesignPatterns.PatternsCriational.Builder.Exemplo_1.Studios;

namespace DesignPatterns.PatternsCriational.Builder.Exemplo_1.Builders
{
    public class Studio26mBuilder : StudioBuilder
    {
        public Studio26mBuilder()
        {
            Studio = new Studio26m();
        }

        public override void DefinirValorStudio()
        {
            Studio.DefinirValorStudio(190000.00M);
        }

        public override void EscolherFinaciamento()
        {
            Studio.EscolherFinanciamento("Investi Fácil");
        }

        public override void EscolherPiso()
        {
            Studio.EscolherPiso("Porcelato");
        }
    }
}
