namespace DataStructure.Models
{
    public class MyArrayList<T>
    {
        private T[] _items { get; set; }

        private int _count { get; set; }

        public MyArrayList() : this(4) {}

        public MyArrayList(int capacity)
        {
            _items = new T[capacity];
            _count = 0;
        }

        public MyArrayList(T[] items)
        {
            _items = items;
            _count = items.Length;
        }

        public int Count
        {
            get { return _count; }
        }

        public int Capacity
        {
            get { return _items.Length; }
        }

        public T First
        {
            get { return _items[0]; }
        }

        public T Last
        {
            get { return _items[_count - 1]; }
        }

        public T this[int index]
        {
            get { return _items[index]; }
            set { _items[index] = value; }
        }

        public void AddFirst(T item)
        {
            var newCount = _count + 1;
            var newItems = new T[newCount];

            newItems[0] = item;

            for (var i = 0; i < _items.Length; i++)
            {
                newItems[i + 1] = _items[i];
            }

            _items = newItems;
            _count = newCount;
        }

        public void AddLast(T item)
        {
            var newCount = _count + 1;

            if (newCount > _items.Length)
            {
                var newCapacity = _items.Length + 4;
                var newItems = new T[newCapacity];
                _Copy(_items, newItems, _items.Length);
                _items = newItems;
            }

            _items[newCount - 1] = item;
            _count = newCount;
        }

        public void Remove(int index)
        {
            for (var i = index; i < _count - 1; i++)
            {
                _items[i] = _items[i + 1];
            }

            _count--;
        }

        private void _Copy(T[] sourceItems, T[] destItems, int sourceCapacity)
        {
            for (var i = 0; i < sourceCapacity; i++)
            {
                destItems[i] = sourceItems[i];
            }
        }
    }
}
