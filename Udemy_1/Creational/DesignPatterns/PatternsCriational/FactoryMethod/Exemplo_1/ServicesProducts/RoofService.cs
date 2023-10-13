using DesignPatterns.PatternsCriational.FactoryMethod.Exemplo_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriational.FactoryMethod.Exemplo_1.ServicesProducts
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
