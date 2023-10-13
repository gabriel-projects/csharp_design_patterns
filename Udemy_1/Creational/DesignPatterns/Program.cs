using DesignPatterns.PatternsCriational.FactoryMethod;

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();
            client.ExecuteCreator();
        }
    }
}