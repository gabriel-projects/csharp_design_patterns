using System.Collections.Generic;
using System.Linq;

namespace DesignPatternsV1.Behavioral.Strategy
{
    public class ConcreteStrategyB : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();
            list.Reverse();
            return list;
        }
    }
} 