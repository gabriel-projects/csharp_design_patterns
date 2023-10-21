using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriational.Propotype.Exemplo_1
{
    public class Cliente
    {
        public void Consumir()
        {
            GerenciadorVendasStudio Gerenciador = new GerenciadorVendasStudio();

            Gerenciador["24m2"] = new Studio("24m^2", "FinaEmpreendimentos", 180000.00M);
            Gerenciador["26m2"] = new Studio("26m^2", "Financiamentos Imóveis Aurora", 190000.00M);
            Gerenciador["28m2"] = new Studio("28m^2", "Imóveis Tabaja", 200000.00M);

            StudioModel? first = Gerenciador["24m2"].Clone();
            StudioModel? second1 = Gerenciador["26m2"].Clone();
            StudioModel? second2 = Gerenciador["26m2"].Clone();
            StudioModel? second3 = Gerenciador["28m2"].Clone();
        }
    }
}
