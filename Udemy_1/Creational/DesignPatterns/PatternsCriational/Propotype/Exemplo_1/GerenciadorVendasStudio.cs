using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriational.Propotype.Exemplo_1
{
    public class GerenciadorVendasStudio
    {
        /// <summary>
        ///  classe define um indexador (this[string key]), que permite acessar os objetos StudioModel no dicionário usando a notação de índice, como se estivesse acessando elementos de uma matriz. Isso significa que você pode usar uma string como índice para acessar um objeto StudioModel específico no dicionário. Por exemplo:
        /// </summary>

        private Dictionary<string, StudioModel> studioModel = new Dictionary<string, StudioModel>();

        public StudioModel this[string key]
        {
            get { return studioModel[key]; }
            set { studioModel[key] = value; }
        }
    }
}
