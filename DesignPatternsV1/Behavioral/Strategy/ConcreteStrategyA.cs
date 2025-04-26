using System.Collections.Generic;
using System.Linq;

namespace DesignPatternsV1.Behavioral.Strategy
{
    public class ConcreteStrategyA : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();
            return list;
        }
    }
} 