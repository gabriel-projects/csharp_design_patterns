namespace DesignPatternsV1.Behavioral.Iterator
{
    public class ConcreteIterator : IIterator
    {
        private ConcreteAggregate _aggregate;
        private int _current = 0;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            _aggregate = aggregate;
        }

        public object Current()
        {
            return _aggregate[_current];
        }

        public bool MoveNext()
        {
            if (_current < _aggregate.Count - 1)
            {
                _current++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _current = 0;
        }
    }
} 