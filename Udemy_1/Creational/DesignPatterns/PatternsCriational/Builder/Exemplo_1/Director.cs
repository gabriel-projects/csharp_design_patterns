using DesignPatterns.PatternsCriational.Builder.Exemplo_1.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriational.Builder.Exemplo_1
{
    public class Director
    {
        public void ContruirStudio(StudioBuilder studioBuilder)
        {
            studioBuilder.EscolherPiso();
            studioBuilder.DefinirValorStudio();
            studioBuilder.EscolherFinaciamento();
        }
    }
}
