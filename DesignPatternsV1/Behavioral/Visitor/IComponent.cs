namespace DesignPatternsV1.Behavioral.Visitor
{
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }
} 