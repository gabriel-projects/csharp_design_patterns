using DesignPatterns.PatternsCriational.AbstractFactory.Exemplo_1.Products.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriational.AbstractFactory.Exemplo_1.Products.Products
{
    public class TrainingWednesdaySaturday : ITraining
    {
        public void GetTraining()
        {
            Console.WriteLine("Treino de Quarta e Sabado");
        }
    }
}