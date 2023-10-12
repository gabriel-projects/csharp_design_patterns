using PizzariaAbstractFactory.AbstractProduct;
using System.Collections;

namespace PizzariaAbstractFactory.ConcrectProducts
{
    //ProductA2
    public sealed class BoloLaranja : Bolo
    {
        public BoloLaranja() : base("Bolo de Laranja", Domain.TipoMassa.Bolo)
        {
            Ingredientes.Add("Com cobertura de calda de laranja");
        }
    }
}
