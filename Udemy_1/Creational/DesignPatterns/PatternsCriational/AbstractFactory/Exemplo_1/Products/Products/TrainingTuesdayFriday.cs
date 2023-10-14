using DesignPatterns.PatternsCriational.AbstractFactory.Exemplo_1.Products.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriational.AbstractFactory.Exemplo_1.Products.Products
{
    public class TrainingTuesdayFriday : ITraining
    {
        public TrainingTuesdayFriday()
        {
            GetTraining();
        }

        public void GetTraining()
        {
            Console.WriteLine("Dieta de terça e sexta");
        }
    }
}
