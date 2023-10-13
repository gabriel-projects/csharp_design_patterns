using DesignPatterns.PatternsCriational.FactoryMethod.Exemplo_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriational.FactoryMethod.Exemplo_1.ServicesProducts
{
    public class MasterService : IService
    {
        public MasterService()
        {
            Console.WriteLine("Produto master criado com sucesso");
        }

        public void ExecuteServiceBilling()
        {
            //Lógica de cobrança
        }
    }
}
