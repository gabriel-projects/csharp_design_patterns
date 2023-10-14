using DesignPatterns.PatternsCriational.AbstractFactory.Exemplo_1.Criational.Interfaces;
using DesignPatterns.PatternsCriational.AbstractFactory.Exemplo_1.Products.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriational.AbstractFactory.Exemplo_1.Criational.Factories
{
    public class MondayThursdayFactory : IFactory
    {
        public MondayThursdayFactory()
        {
            DailyRoutines();
        }

        public void DailyRoutines()
        {
            Console.WriteLine("Factory Segunda e Quinta Criada");

            DietMondayThursday diet = new DietMondayThursday();
            TrainingMondayThursday training = new TrainingMondayThursday();


            diet.GetFood();
            training.GetTraining();
        }
    }
}
