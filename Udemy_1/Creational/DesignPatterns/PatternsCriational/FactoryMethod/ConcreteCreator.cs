using DesignPatterns.PatternsCriational.FactoryMethod.Enums;
using DesignPatterns.PatternsCriational.FactoryMethod.Interfaces;
using DesignPatterns.PatternsCriational.FactoryMethod.ServicesProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriational.FactoryMethod
{
    public class ConcreteCreator : ServiceFactory
    {
        public override IService FactoryProduct(EServiceType eService)
        {
            switch (eService)
            {
                case EServiceType.Traditional:
                    return new TraditionalService();
                case EServiceType.Premium: 
                    return new PremiumService();
                case EServiceType.Master:
                    return new MasterService();
                case EServiceType.Roof:
                    return new RoofService();
                default:
                    return null;
            }
        }
    }
}
