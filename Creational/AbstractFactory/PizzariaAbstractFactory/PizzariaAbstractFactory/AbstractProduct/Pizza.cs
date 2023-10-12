

using PizzariaAbstractFactory.Domain;

namespace PizzariaAbstractFactory.AbstractProduct
{
    //AbstractProductB
    public abstract class Pizza : MassaBase
    {
        public Pizza(string nome, TipoMassa tipo) : base(nome, tipo)
        {
        }
    }
}
