using DesignPatterns.PatternsCriational.Builder.Exemplo_1.Studios;

namespace DesignPatterns.PatternsCriational.Builder.Exemplo_1.Builders
{
    public abstract class StudioBuilder
    {
        protected Studio Studio;
        public Studio GetStudio()
        {
            return Studio;
        }

        public abstract void EscolherPiso();
        public abstract void EscolherFinaciamento();
        public abstract void DefinirValorStudio();
    }
}
