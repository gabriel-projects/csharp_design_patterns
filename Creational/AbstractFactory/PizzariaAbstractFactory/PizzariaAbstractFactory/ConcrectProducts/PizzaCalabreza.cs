using PizzariaAbstractFactory.AbstractProduct;

namespace PizzariaAbstractFactory.ConcrectProducts
{
    //ProductB1
    public sealed class PizzaCalabreza : Pizza
    {
        public PizzaCalabreza() : base("Pizza Calabreza", Domain.TipoMassa.Pizza)
        {
            Ingredientes.Add("Calabreza em cubos e tomates em cubos");
        }
    }
}
