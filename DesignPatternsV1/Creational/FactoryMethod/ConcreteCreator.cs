namespace DesignPatternsV1.Creational.FactoryMethod
{
    public class ConcreteCreator : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct();
        }
    }
} 