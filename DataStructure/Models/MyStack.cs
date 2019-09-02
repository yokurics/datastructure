namespace DataStructure.Models
{
    public class MyStack<T>
    {
        private MyArrayList<T> _items { get; set; }

        public MyStack() : this(4) { }

        public MyStack(int capacity)
        {
            _items = new MyArrayList<T>(capacity);
        }

        public MyStack(T[] items)
        {
            _items = new MyArrayList<T>(items);
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public int Capacity
        {
            get { return _items.Capacity;  }
        }

        public T Pop()
        {
            var lastItem = _items.Last;
            _items.Remove(_items.Count - 1);
            return lastItem;
        }

        public void Push(T item)
        {
            _items.AddLast(item);
        }
    }
}
