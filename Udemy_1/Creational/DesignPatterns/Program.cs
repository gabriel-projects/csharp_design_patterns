using DesignPatterns.PatternsCriational.AbstractFactory.Exemplo_1;
using DesignPatterns.PatternsCriational.FactoryMethod.Exemplo_1;

namespace DesignPatterns
{
    public class Program
    {
        //Factory Method
        //static void Main(string[] args)
        //{
        //    var client = new FactoryMethodClient();
        //    client.ExecuteCreator();
        //}

        //Abstract Factory
        static void Main(string[] args)
        {
            var client = new AbstractFactoryClient();
            client.Execute();
        }
    }
}