using PizzariaAbstractFactory.AbstractProduct;
using System.Collections;

namespace PizzariaAbstractFactory.ConcrectProducts
{
    //ProductA1
    public sealed class BoloChocolate : Bolo
    {
        public BoloChocolate() : base("Bolo de Chocolate", Domain.TipoMassa.Bolo)
        {
            Ingredientes.Add("Com cobertura de chocolate Nestlé");
        }        
    }
}
