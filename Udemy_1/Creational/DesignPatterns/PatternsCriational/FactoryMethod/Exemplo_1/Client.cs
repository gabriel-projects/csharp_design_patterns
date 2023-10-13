using DesignPatterns.PatternsCriational.FactoryMethod.Exemplo_1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriational.FactoryMethod.Exemplo_1
{
    public class Client
    {
        public void ExecuteCreator()
        {
            var client = new ConcreteCreator();

            var continuar = true;

            while (continuar)
            {
                Console.WriteLine("Seleciona o tipo de serviço \n");
                Console.WriteLine("0 - Tradicional");
                Console.WriteLine("1 - Premium");
                Console.WriteLine("2 - Master");
                Console.WriteLine("3 - Cobertura");


                Console.Write("Digite o número do serviço que deseja cobrar: ");
                int typeService = Convert.ToInt32(Console.ReadLine());


                var serviceProduct = client.FactoryProduct((EServiceType)typeService);

                Console.Write("Deseja calcular outro serviço? (1-SIM ou 2-NÃO): ");
                int resp = Convert.ToInt32(Console.ReadLine());

                continuar = resp == 1;
            }
        }
    }
}
