using PizzariaAbstractFactory.AbstractFactory;
using PizzariaAbstractFactory.AbstractProduct;
using PizzariaAbstractFactory.ConcrectProducts;
using PizzariaAbstractFactory.Domain;
using System;

namespace PizzariaAbstractFactory.ConcrectFactory
{
    //ConcreteFactory2
    public sealed class PizzaFactory : MassasAbstractFactory
    {
        public override MassaBase CriaMassa(TipoMassa tipoMassa)
        {
            var tipoPizza = (TipoPizza)tipoMassa;

            switch (tipoPizza)
            {
                case TipoPizza.Mussarela:
                {
                    return new PizzaMussarela();
                }
                case TipoPizza.Calabreza:
                {
                   return new PizzaCalabreza();
                }
                default:
                 throw new ArgumentOutOfRangeException("Tipo não implementado");
            }
        }
    }
}
