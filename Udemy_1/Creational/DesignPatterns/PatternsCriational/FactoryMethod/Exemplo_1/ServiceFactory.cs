using DesignPatterns.PatternsCriational.FactoryMethod.Exemplo_1.Enums;
using DesignPatterns.PatternsCriational.FactoryMethod.Exemplo_1.Interfaces;

namespace DesignPatterns.PatternsCriational.FactoryMethod.Exemplo_1
{
    public abstract class ServiceFactory
    {
        public abstract IService FactoryProduct(EServiceType eService);
    }
}
