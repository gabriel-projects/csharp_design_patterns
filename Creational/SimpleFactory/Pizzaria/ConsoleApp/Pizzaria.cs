using ConsoleApp.AbstractFactory;
using ConsoleApp.SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Pizzaria
    {
        public static void SolicitaPizza()
        {
            Console.WriteLine("======Pizzaria==========");
            Console.WriteLine("Informe a Pizza (C)alabreza ou (M)ussarela \n");
            var tipo = Console.ReadLine()?.ToUpper();
            try
            {
                Pizza pizza = PizzaSimpleFactory.CriaPizza(tipo);
                pizza.Preparar();
                pizza.Assar(10);
                pizza.Embalar();
                Console.WriteLine("Pizza concluída.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro :" + ex.Message);
            }
        }
    }
}
