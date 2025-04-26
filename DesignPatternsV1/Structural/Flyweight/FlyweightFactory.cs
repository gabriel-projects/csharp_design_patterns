using System.Collections.Generic;

namespace DesignPatternsV1.Structural.Flyweight
{
    public class FlyweightFactory
    {
        private Dictionary<string, Flyweight> _flyweights = new Dictionary<string, Flyweight>();

        public FlyweightFactory(params string[] initialStates)
        {
            foreach (var state in initialStates)
            {
                _flyweights.Add(state, new Flyweight(state));
            }
        }

        public Flyweight GetFlyweight(string key)
        {
            if (!_flyweights.ContainsKey(key))
            {
                System.Console.WriteLine("FlyweightFactory: Can't find a flyweight, creating new one.");
                _flyweights.Add(key, new Flyweight(key));
            }
            return _flyweights[key];
        }

        public void ListFlyweights()
        {
            var count = _flyweights.Count;
            System.Console.WriteLine($"\nFlyweightFactory: I have {count} flyweights:");
            foreach (var flyweight in _flyweights)
            {
                System.Console.WriteLine(flyweight.Key);
            }
        }
    }
} 