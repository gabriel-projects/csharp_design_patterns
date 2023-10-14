using DesignPatterns.PatternsCriational.AbstractFactory.Exemplo_1.Criational.Interfaces;
using DesignPatterns.PatternsCriational.AbstractFactory.Exemplo_1.Products.Interfaces;
using DesignPatterns.PatternsCriational.AbstractFactory.Exemplo_1.Products.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriational.AbstractFactory.Exemplo_1.Criational.Factories
{
    public class WednesdaySaturdayFactory : IFactory
    {
        public WednesdaySaturdayFactory()
        {
            DailyRoutines();
        }

        public void DailyRoutines()
        {
            Console.WriteLine("Factory quarta e sabado criado");

            DietWednesdaySaturday diet = new DietWednesdaySaturday();
            TrainingWednesdaySaturday training = new TrainingWednesdaySaturday();

            diet.GetFood();
            training.GetTraining();
        }
    }
}
