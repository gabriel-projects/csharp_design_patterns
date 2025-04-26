namespace DesignPatternsV1.Behavioral.Iterator
{
    public interface IIterator
    {
        object Current();
        bool MoveNext();
        void Reset();
    }
} 