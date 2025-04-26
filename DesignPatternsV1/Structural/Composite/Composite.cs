using System.Collections.Generic;

namespace DesignPatternsV1.Structural.Composite
{
    public class Composite : IComponent
    {
        private List<IComponent> _children = new List<IComponent>();

        public string Operation()
        {
            int i = 0;
            string result = "Branch(";

            foreach (IComponent component in _children)
            {
                result += component.Operation();
                if (i != _children.Count - 1)
                {
                    result += "+";
                }
                i++;
            }

            return result + ")";
        }

        public void Add(IComponent component)
        {
            _children.Add(component);
        }

        public void Remove(IComponent component)
        {
            _children.Remove(component);
        }

        public bool IsComposite()
        {
            return true;
        }
    }
} 