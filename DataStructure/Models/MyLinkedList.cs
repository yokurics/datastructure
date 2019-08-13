using System;

namespace DataStructure.Models
{
    public class MyLinkedList<T>
    {
        public class Node
        {
            private T _value { get; set; }
            private Node _previous { get; set; }
            private Node _next { get; set; }

            internal Node(T value, Node previous, Node next)
            {
                _value = value;
                _previous = previous;
                _next = next;
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

        private Node _dummy { get; set; }

        public MyLinkedList()
        {
            _dummy = new Node(default(T), null, null);
            _dummy.Next = _dummy;
            _dummy.Previous = _dummy;
        }

        public Node First
        {
            get { return _dummy.Next; }
        }

        public Node Last
        {
            get { return _dummy.Previous; }
        }

        public Node End
        {
            get { return _dummy; }
        }

        public int Count
        {
            get
            {
                var count = 0;

                for (var node = First; node != End; node = node.Next)
                {
                    count++;
                }

                return count;
            }
        }

        public Node AddBefore(Node node, T element)
        {
            var newNode = new Node(element, node.Previous, node);
            node.Previous.Next = newNode;
            node.Previous = newNode;
            return newNode;
        }

        public Node AddAfter(Node node, T element)
        {
            var newNode = new Node(element, node, node.Next);
            node.Next.Previous = newNode;
            node.Next = newNode;
            return newNode;
        }

        public Node AddFirst(T element)
        {
            return AddAfter(_dummy, element);
        }

        public Node AddLast(T element)
        {
            return AddBefore(_dummy, element);
        }
    }
}
