namespace DesignPatternsV1.Behavioral.Iterator
{
    public interface IAggregate
    {
        IIterator CreateIterator();
    }
} 