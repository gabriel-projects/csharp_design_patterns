namespace DesignPatternsV1.Structural.Composite
{
    public class Leaf : IComponent
    {
        public string Operation()
        {
            return "Leaf";
        }

        public void Add(IComponent component)
        {
            // Leaf cannot add components
        }

        public void Remove(IComponent component)
        {
            // Leaf cannot remove components
        }

        public bool IsComposite()
        {
            return false;
        }
    }
} 