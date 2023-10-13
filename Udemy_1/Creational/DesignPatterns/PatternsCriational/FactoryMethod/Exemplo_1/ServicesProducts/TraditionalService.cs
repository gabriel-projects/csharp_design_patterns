using DesignPatterns.PatternsCriational.FactoryMethod.Exemplo_1.Interfaces;

namespace DesignPatterns.PatternsCriational.FactoryMethod.Exemplo_1.ServicesProducts
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
