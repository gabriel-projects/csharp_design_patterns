using PizzariaAbstractFactory.AbstractFactory;
using PizzariaAbstractFactory.AbstractProduct;
using PizzariaAbstractFactory.ConcrectProducts;
using PizzariaAbstractFactory.Domain;
using System;

namespace PizzariaAbstractFactory.ConcrectFactory
{
    //ConcreteFactory1
    public sealed class BoloFactory : MassasAbstractFactory
    {
        public override MassaBase CriaMassa(TipoMassa tipoMassa)
        {
            var tipoBolo = (TipoBolo)tipoMassa;

            switch (tipoBolo)
            {
                case TipoBolo.Chocolate:
                    {
                        return new BoloChocolate();
                    }
                case TipoBolo.Laranja:
                    {
                        return new BoloLaranja();
                    }
                default:
                    throw new ArgumentOutOfRangeException("Tipo não implementado");
            }
        }

    }
}
