namespace DesignPatternsV1.Creational.AbstractFactory
{
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();
        IAbstractProductB CreateProductB();
    }
} 