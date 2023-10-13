using DesignPatterns.PatternsCriational.FactoryMethod.Enums;
using DesignPatterns.PatternsCriational.FactoryMethod.Interfaces;

namespace DesignPatterns.PatternsCriational.FactoryMethod
{
    public abstract class ServiceFactory
    {
        public abstract IService FactoryProduct(EServiceType eService);
    }
}
