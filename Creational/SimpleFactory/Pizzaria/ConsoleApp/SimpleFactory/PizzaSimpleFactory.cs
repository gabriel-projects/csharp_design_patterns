using ConsoleApp.AbstractFactory;
using ConsoleApp.ConcrectModel;

namespace ConsoleApp.SimpleFactory;

//classe nao pode ser herdada
public sealed class PizzaSimpleFactory
{
    //Lógica de criação do objetos
    public static Pizza CriaPizza(string tipo)
    {
        Pizza pizza = tipo switch
        {
            "C" => new PizzaCalabreza(),
            "M" => new PizzaMussarela(),
            _ => throw new ApplicationException($"Tipo {tipo} de pizza inválido")
        };
        return pizza;
    }
}
