using System.Collections.Generic;

namespace DesignPatternsV1.Creational.Builder
{
    public class ConcreteProduct : IProduct
    {
        private List<string> _parts = new List<string>();

        public void AddPart(string part)
        {
            _parts.Add(part);
        }

        public string ListParts()
        {
            return $"Product parts: {string.Join(", ", _parts)}\n";
        }
    }
} 