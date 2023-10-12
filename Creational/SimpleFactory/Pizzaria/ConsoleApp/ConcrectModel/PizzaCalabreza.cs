using ConsoleApp.AbstractFactory;

namespace ConsoleApp.ConcrectModel
{
    public class PizzaCalabreza : Pizza
    {
        public PizzaCalabreza()
        {
            Nome = "Calabreza";
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
