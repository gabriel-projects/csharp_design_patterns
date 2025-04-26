namespace DesignPatternsV1.Structural.Composite
{
    public interface IComponent
    {
        string Operation();
        void Add(IComponent component);
        void Remove(IComponent component);
        bool IsComposite();
    }
} 