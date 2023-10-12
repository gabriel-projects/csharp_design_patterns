using PizzariaAbstractFactory.AbstractProduct;

namespace PizzariaAbstractFactory.ConcrectProducts
{
    //ProductB2
    //Selead n pode ser extendida
    public sealed class PizzaMussarela : Pizza
    {
        public PizzaMussarela() : base("Pizza Mussarela", Domain.TipoMassa.Pizza)
        {
            Ingredientes.Add("Queijo mussarela gratinado e molho de tomate");
        }
    }
}
