using System;

namespace DataStructure.Models
{
    public class MyBinaryTreeNode<T>
    {
        public T Value { get; set; }
        public MyBinaryTreeNode<T> Left { get; set; }
        public MyBinaryTreeNode<T> Right { get; set; }

        public MyBinaryTreeNode()
        {
            Value = default(T);
        }

        public MyBinaryTreeNode(T value)
        {
            Value = value;
        }
    }

    public class MyBinaryTree<T>
    {
        public MyBinaryTreeNode<T> Root { get; set; }

        public void RecursivePrintPreOrder(MyBinaryTreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }

            Console.WriteLine(node.Value);
            RecursivePrintPreOrder(node.Left);
            RecursivePrintPreOrder(node.Right);
        }

        public void IterativePrintPreOrder(MyBinaryTreeNode<T> rootNode)
        {
            var stack = new MyStack<MyBinaryTreeNode<T>>();
            stack.Push(rootNode);

            while (stack.Count > 0)
            {
                var node = stack.Pop();
                Console.WriteLine(node.Value);

                if (node.Right != null)
                {
                    stack.Push(node.Right);
                }

                if (node.Left != null)
                {
                    stack.Push(node.Left);
                }
            }
        }

        public void RecursivePrintInOrder(MyBinaryTreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }

            RecursivePrintInOrder(node.Left);
            Console.WriteLine(node.Value);
            RecursivePrintInOrder(node.Right);
        }

        public void IterativePrintInOrder(MyBinaryTreeNode<T> rootNode)
        {
            var stack = new MyStack<MyBinaryTreeNode<T>>();
            var currentNode = rootNode;

            while (stack.Count > 0 || currentNode != null)
            {
                if (currentNode != null)
                {
                    stack.Push(currentNode);
                    currentNode = currentNode.Left;
                }
                else
                {
                    var node = stack.Pop();
                    Console.WriteLine(node.Value);
                    currentNode = node.Right;
                }
            }
        }

        public void RecursivePrintPostOrder()
        {
            throw new NotImplementedException();
        }

        public void IterativePrintPostOrder()
        {
            throw new NotImplementedException();
        }

        public MyBinaryTreeNode<int> RecursiveSearch(MyBinaryTreeNode<int> rootNode, int value)
        {
            if (rootNode == null)
            {
                return null;
            }

            if (rootNode.Value == value)
            {
                return rootNode;
            }
            else if (rootNode.Value > value)
            {
                return RecursiveSearch(rootNode.Left, value);
            }
            else
            {
                return RecursiveSearch(rootNode.Right, value);
            }
        }

        public MyBinaryTreeNode<int> IterativeSearch(MyBinaryTreeNode<int> rootNode, int value)
        {
            var currentNode = rootNode;

            while (true)
            {
                if (currentNode == null)
                {
                    break;
                }

                if (currentNode.Value == value)
                {
                    return currentNode;
                }
                else if (currentNode.Value > value)
                {
                    currentNode = currentNode.Left;
                }
                else
                {
                    currentNode = currentNode.Right;
                }
            }

            return null;
        }
    }
}
