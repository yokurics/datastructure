namespace DataStructure.Models
{
    public class MyLinkedList<T>
    {
        public class Node
        {
            private T _value { get; set; }
            private Node _previous { get; set; }
            private Node _next { get; set; }

            internal Node(T value)
            {
                _value = value;
            }

            public T Value
            {
                get { return _value; }
                set { _value = value; }
            }

            public Node Previous
            {
                get { return _previous; }
                internal set { _previous = value; }
            }

            public Node Next
            {
                get { return _next; }
                internal set { _next = value; }
            }
        }

        private Node _first { get; set; }
        private Node _last { get; set; }
        private int _count { get; set; }

        public MyLinkedList()
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

        public Node AddBefore(Node node, T element)
        {
            var newNode = new Node(element);

            if (node.Previous != null)
            {
                node.Previous.Next = newNode;
                newNode.Previous = node.Previous;
            }

            node.Previous = newNode;
            newNode.Next = node;
            _count++;
            return newNode;
        }

        public Node AddAfter(Node node, T element)
        {
            var newNode = new Node(element);

            if (node.Next != null)
            {
                node.Next.Previous = newNode;
                newNode.Next = node.Next;
            }

            node.Next = newNode;
            newNode.Previous = node;
            _count++;
            return newNode;
        }

        public Node AddFirst(T element)
        {
            if (_first == null)
            {
                _first = new Node(element);
                _last = _first;
                _count++;
            }
            else
            {
                _first = AddBefore(_first, element);
            }

            return _first;
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
    }
}
