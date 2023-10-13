using DesignPatterns.PatternsCriational.FactoryMethod.Exemplo_1;

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