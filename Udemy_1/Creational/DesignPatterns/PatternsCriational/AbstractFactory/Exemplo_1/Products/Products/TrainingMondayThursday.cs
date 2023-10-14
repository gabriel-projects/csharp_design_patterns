using DesignPatterns.PatternsCriational.AbstractFactory.Exemplo_1.Products.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriational.AbstractFactory.Exemplo_1.Products.Products
{
    public class TrainingMondayThursday : ITraining
    {
        public TrainingMondayThursday()
        {
            GetTraining();
        }

        public void GetTraining()
        {
            Console.WriteLine("Treino de segunda e Quinta");
        }
    }
}
