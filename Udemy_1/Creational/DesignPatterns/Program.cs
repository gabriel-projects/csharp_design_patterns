using DesignPatterns.PatternsCriational.AbstractFactory.Exemplo_1;
using DesignPatterns.PatternsCriational.Builder.Exemplo_1;
using DesignPatterns.PatternsCriational.FactoryMethod.Exemplo_1;
using DesignPatterns.PatternsCriational.Propotype.Exemplo_1;
using DesignPatterns.PatternsCriational.SingletonPattern;

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
        //static void Main(string[] args)
        //{
        //    var client = new AbstractFactoryClient();
        //    client.Execute();
        //}

        //singleton
        //static void Main(string[] args)
        //{
        //    var client = new SingletonClient();
        //    client.ConsumeDb();
        //}

        //Builder
        //static void Main(string[] args)
        //{
        //    var client = new BuilderClient();
        //    client.ConsumirDados();
        //}

        //prototype
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Consumir();
        }
    }
}