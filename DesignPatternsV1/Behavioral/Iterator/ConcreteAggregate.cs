using System.Collections.Generic;

namespace DesignPatternsV1.Behavioral.Iterator
{
    public class ConcreteAggregate : IAggregate
    {
        private List<object> _items = new List<object>();

        public void Add(object item)
        {
            _items.Add(item);
        }

        public IIterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }
    }
} 