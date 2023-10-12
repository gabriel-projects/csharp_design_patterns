using DesignPatterns.PatternsCriational.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriational.FactoryMethod.ServicesProducts
{
    public class RoofService : IService
    {
        public RoofService()
        {
            Console.WriteLine("Produto Cobertura Criado com sucesso");
        }

        public void ExecuteServiceBilling()
        {
            //Lógica de cobrança
        }
    }
}
