namespace DataStructure.Models
{
    public class MyOneWayLinkedList<T>
    {
        public class Node
        {
            public T Value { get; set; }
            public Node Next { get; set; }

            internal Node(T value)
            {
                Value = value;
            }
        }

        private Node _first { get; set; }
        private Node _last { get; set; }
        private int _count { get; set; }

        public MyOneWayLinkedList()
        {
        }

        public Node First
        {
            get { return _first; }
        }

        public Node Last
        {
            get { return _last; }
        }

        public int Count
        {
            get { return _count; }
        }

        public Node AddAfter(Node node, T element)
        {
            var newNode = new Node(element);

            if (node.Next != null)
            {
                newNode.Next = node.Next;
            }

            node.Next = newNode;
            _count++;
            return newNode;
        }

        public Node AddLast(T element)
        {
            if (_last == null)
            {
                _last = new Node(element);
                _first = _last;
                _count++;
            }
            else
            {
                _last = AddAfter(_last, element);
            }

            return _last;
        }

        public void Remove(Node node)
        {
            var nextNode = node.Next;

            if (nextNode == null)
            {
                RemoveLast();
            }
            else
            {
                node.Value = nextNode.Value;
                node.Next = nextNode.Next;
            }
        }

        public void RemoveLast()
        {
            if (_first == null)
            {
                return;
            }

            if (_first.Next == null)
            {
                _first = null;
                _last = null;
                return;
            }

            var node = _first;

            while (node.Next != null)
            {
                _last = node;
                node = node.Next;
            }

            _last.Next = null;
        }
    }
}
