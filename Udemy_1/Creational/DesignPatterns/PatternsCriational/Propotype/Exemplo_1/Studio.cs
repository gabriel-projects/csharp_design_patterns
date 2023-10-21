using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriational.Propotype.Exemplo_1
{
    public class Studio : StudioModel
    {
        private string _nome;
        private string _tipoFinanciamento;
        private decimal _valorStudio;

        public Studio(string nome, string tipoFinanciamento, decimal valorStudio)
        {
            _nome = nome;
            _tipoFinanciamento = tipoFinanciamento;
            _valorStudio = valorStudio;
        }

        public override StudioModel? Clone()
        {
            Console.WriteLine(new String('-', 40));
            Console.WriteLine($"Studio clonado: {_nome}\nFinanciamento: {_tipoFinanciamento}\nValor:  {_valorStudio.ToString("C")}\n\n");
            return this.MemberwiseClone() as StudioModel;
        }
    }
}
