using DesignPatterns.PatternsCriational.AbstractFactory.Exemplo_1.Criational.Factories;
using DesignPatterns.PatternsCriational.AbstractFactory.Exemplo_1.Criational.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriational.AbstractFactory.Exemplo_1
{
    public class AbstractFactoryClient
    {
        public void Execute()
        {
            var continuar = true;

            while (continuar)
            {
                IFactory factory = null;

                Console.WriteLine("Rotina de treino A,B e C:");
                Console.WriteLine("1-Segunda Feira e Quinta Feira.");
                Console.WriteLine("2-Terça Feira e Sexta Feira.");
                Console.WriteLine("3-Segunda Feira e Quinta Feira.\n");

                Console.Write("Selecione a rotina de treino você deseja: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        factory = new MondayThursdayFactory();
                        break;
                    case "2":
                        factory = new TuesdayFridayFactory();
                        break;
                    case "3":
                        factory = new WednesdaySaturdayFactory();
                        break;
                    default:
                        break;
                }


                Console.Write("\nDeseja ver outra rotina? (1-Sim ou 2-Não): ");
                var resp = Convert.ToInt32(Console.ReadLine());

                continuar = resp == 1 ? true : false;
            }

        }
    }
}
