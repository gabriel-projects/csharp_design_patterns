using DesignPatterns.PatternsCriational.FactoryMethod.Interfaces;

namespace DesignPatterns.PatternsCriational.FactoryMethod.ServicesProducts
{
    public class TraditionalService : IService
    {
        public TraditionalService()
        {
            Console.WriteLine("produto Tradicional criado");
        }

        public void ExecuteServiceBilling()
        {
            //Lógica de cobrança
        }
    }
}
