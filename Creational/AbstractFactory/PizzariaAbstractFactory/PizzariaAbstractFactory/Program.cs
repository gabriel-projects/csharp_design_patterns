using PizzariaAbstractFactory.AbstractFactory;
using PizzariaAbstractFactory.AbstractProduct;
using PizzariaAbstractFactory.Domain;
using System;

//Obtém as fábricas
var boloFactory = MassasAbstractFactory.CriaFabricaMassas(TipoMassa.Bolo);
var pizzaFactory = MassasAbstractFactory.CriaFabricaMassas(TipoMassa.Pizza);

//cria os objetos com base no tipo : bolo
var bolo1 = boloFactory.CriaMassa((TipoMassa)TipoBolo.Chocolate);
var bolo2 = boloFactory.CriaMassa((TipoMassa)TipoBolo.Laranja);

//cria os objetos com base no tipo : pizza
var pizza1 = pizzaFactory.CriaMassa((TipoMassa)TipoPizza.Mussarela);
var pizza2 = pizzaFactory.CriaMassa((TipoMassa)TipoPizza.Calabreza);

//exibe os detalhes
ExibeDetalhes(bolo1);
ExibeDetalhes(bolo2);
ExibeDetalhes(pizza1);
ExibeDetalhes(pizza2);

Console.ReadLine();

static void ExibeDetalhes(MassaBase massaBase)
{
    Console.WriteLine($"Tipo : {massaBase.TipoMassa}");
    Console.WriteLine(massaBase.Nome);
    Console.WriteLine(massaBase.Ingredientes[0].ToString());
    Console.WriteLine("\nn");
}