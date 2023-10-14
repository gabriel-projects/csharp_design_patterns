using DesignPatterns.PatternsCriational.Builder.Exemplo_1.Builders;
using DesignPatterns.PatternsCriational.Builder.Exemplo_1.Studios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriational.Builder.Exemplo_1
{
    public class BuilderClient
    {
        public void ConsumirDados()
        {
            Director director = new Director();
            StudioBuilder studioBuilder;
            Studio studio;

            studioBuilder = new Studio24mBuilder();
            director.ContruirStudio(studioBuilder);
            studio = studioBuilder.GetStudio();
            ImprimirResultado(studio, "24m2");

            studioBuilder = new Studio26mBuilder();
            director.ContruirStudio(studioBuilder);
            studio = studioBuilder.GetStudio();
            ImprimirResultado(studio, "26m2");

            studioBuilder = new Studio28mBuilder();
            director.ContruirStudio(studioBuilder);
            studio = studioBuilder.GetStudio();
            ImprimirResultado(studio, "28m2");

        }

        private void ImprimirResultado(Studio studio, string nome)
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine($"[+] - Studio {nome}");
            Console.WriteLine("Valor: {0}\nPiso: {1}\nTipo de financiamento: {2}", studio.Valor.ToString("C"), studio.TipoPiso, studio.TipoFinanciamento);
        }
    }
}
