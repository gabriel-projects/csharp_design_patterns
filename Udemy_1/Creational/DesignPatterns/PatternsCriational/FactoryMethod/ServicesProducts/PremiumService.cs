using DesignPatterns.PatternsCriational.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriational.FactoryMethod.ServicesProducts
{
    public class PremiumService : IService
    {
        public PremiumService()
        {
            Console.WriteLine("produto premium criado");
        }

        public void ExecuteServiceBilling()
        {
            //Lógica de cobrança
        }
    }
}
