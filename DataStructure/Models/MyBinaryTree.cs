using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Models
{
    public class MyBinaryTree<T>
    {
        public class TreeNode
        {
            public T Value { get; set; }
            public TreeNode Left { get; set; }
            public TreeNode Right { get; set; }

            internal TreeNode(T value)
            {
                Value = value;
            }
        }

        public TreeNode Root { get; set; }

        public void RecursivePrintPreOrder(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            Console.WriteLine(node.Value);
            RecursivePrintPreOrder(node.Left);
            RecursivePrintPreOrder(node.Right);
        }

        public void IterativePrintPreOrder()
        {
            var stack = new MyStack<TreeNode>();
            stack.Push(Root);

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

        public void RecursivePrintInOrder(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            RecursivePrintPreOrder(node.Left);
            Console.WriteLine(node.Value);
            RecursivePrintPreOrder(node.Right);
        }

        public void IterativePrintInOrder()
        {
            var stack = new MyStack<TreeNode>();
            var currentNode = Root;

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

        }

        public void IterativePrintPostOrder()
        {

        }
    }
}
