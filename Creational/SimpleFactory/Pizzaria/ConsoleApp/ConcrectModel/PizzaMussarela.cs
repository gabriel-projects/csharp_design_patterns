using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.AbstractFactory;

namespace ConsoleApp.ConcrectModel
{
    internal class PizzaMussarela : Pizza
    {
        public PizzaMussarela()
        {
            Nome = "Mussarela";
        }
        
        public override void Preparar()
        {
            Console.WriteLine($"Preparando a pizza de {Nome}");
        }

        public override void Assar(int tempo)
        {
            Console.WriteLine($"Pizza de {Nome} assando por {tempo} minutos");
        }

        public override void Embalar()
        {
            Console.WriteLine($"Embalando a pizza de {Nome}");
        }
    }
}
