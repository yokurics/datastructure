using DataStructure.Extentions;
using DataStructure.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;

namespace DataStructure.Tests
{
    [TestClass]
    public class TestMyBinaryTree
    {
        [TestMethod]
        public void TestRecursivePrintPreOrder()
        {
            var expected = string.Join("\r\n", new int[] { 1, 2, 4, 8, 9, 5, 10, 11, 3, 6, 12, 13, 7, 14, 15 });
            var binaryTree = CreateDummyBinaryTree();
            var memoryStream = new MemoryStream();

            using (var streamWriter = new StreamWriter(memoryStream))
            {
                var defaultOut = Console.Out;
                Console.SetOut(streamWriter);
                binaryTree.RecursivePrintPreOrder(binaryTree.Root);
                streamWriter.Flush();
                memoryStream.Seek(0, SeekOrigin.Begin);
                Console.SetOut(defaultOut);
            }

            var actual = Encoding.ASCII.GetString(memoryStream.ToArray()).Trim();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIterativePrintPreOrder()
        {
            var expected = string.Join("\r\n", new int[] { 1, 2, 4, 8, 9, 5, 10, 11, 3, 6, 12, 13, 7, 14, 15 });
            var binaryTree = CreateDummyBinaryTree();
            var memoryStream = new MemoryStream();

            using (var streamWriter = new StreamWriter(memoryStream))
            {
                var defaultOut = Console.Out;
                Console.SetOut(streamWriter);
                binaryTree.IterativePrintPreOrder(binaryTree.Root);
                streamWriter.Flush();
                memoryStream.Seek(0, SeekOrigin.Begin);
                Console.SetOut(defaultOut);
            }

            var actual = Encoding.ASCII.GetString(memoryStream.ToArray()).Trim();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRecursivePrintInOrder()
        {
            var expected = string.Join("\r\n", new int[] { 8, 4, 9, 2, 10, 5, 11, 1, 12, 6, 13, 3, 14, 7, 15 });
            var binaryTree = CreateDummyBinaryTree();
            var memoryStream = new MemoryStream();

            using (var streamWriter = new StreamWriter(memoryStream))
            {
                var defaultOut = Console.Out;
                Console.SetOut(streamWriter);
                binaryTree.RecursivePrintInOrder(binaryTree.Root);
                streamWriter.Flush();
                memoryStream.Seek(0, SeekOrigin.Begin);
                Console.SetOut(defaultOut);
            }

            var actual = Encoding.ASCII.GetString(memoryStream.ToArray()).Trim();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIterativePrintInOrder()
        {
            var expected = string.Join("\r\n", new int[] { 8, 4, 9, 2, 10, 5, 11, 1, 12, 6, 13, 3, 14, 7, 15 });
            var binaryTree = CreateDummyBinaryTree();
            var memoryStream = new MemoryStream();

            using (var streamWriter = new StreamWriter(memoryStream))
            {
                var defaultOut = Console.Out;
                Console.SetOut(streamWriter);
                binaryTree.IterativePrintInOrder(binaryTree.Root);
                streamWriter.Flush();
                memoryStream.Seek(0, SeekOrigin.Begin);
                Console.SetOut(defaultOut);
            }

            var actual = Encoding.ASCII.GetString(memoryStream.ToArray()).Trim();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRecursiveSearch()
        {
            var binaryTree = CreateDummySortedBinaryTree();
            var values = new int[] { 1, 3, 7, 13 };
            var expecteds = new int?[] { 1, 3, 7, null };
            var actuals = new int?[4];

            for (var i = 0; i < values.Length; i++)
            {
                actuals[i] = binaryTree.RecursiveSearch(binaryTree.Root, values[i])?.Value;
            }

            Assert.AreEqual(expecteds.Length, actuals.Length);
            CollectionAssert.AreEqual(expecteds, actuals);
        }

        [TestMethod]
        public void TestIterativeSearch()
        {
            var binaryTree = CreateDummySortedBinaryTree();
            var values = new int[] { 1, 3, 7, 13 };
            var expecteds = new int?[] { 1, 3, 7, null };
            var actuals = new int?[4];

            for (var i = 0; i < values.Length; i++)
            {
                actuals[i] = binaryTree.IterativeSearch(binaryTree.Root, values[i])?.Value;
            }

            Assert.AreEqual(expecteds.Length, actuals.Length);
            CollectionAssert.AreEqual(expecteds, actuals);
        }

        public MyBinaryTree<int> CreateDummyBinaryTree()
        {
            var binaryTree = new MyBinaryTree<int>();
            binaryTree.Root = new MyBinaryTreeNode<int>(1);
            binaryTree.Root.AddChildNodes(2, 3);
            binaryTree.Root.Left.AddChildNodes(4, 5);
            binaryTree.Root.Right.AddChildNodes(6, 7);
            binaryTree.Root.Left.Left.AddChildNodes(8, 9);
            binaryTree.Root.Left.Right.AddChildNodes(10, 11);
            binaryTree.Root.Right.Left.AddChildNodes(12, 13);
            binaryTree.Root.Right.Right.AddChildNodes(14, 15);
            return binaryTree;
        }

        public MyBinaryTree<int> CreateDummySortedBinaryTree()
        {
            var binaryTree = new MyBinaryTree<int>();
            binaryTree.Root = new MyBinaryTreeNode<int>(4);
            binaryTree.Root.AddChildNodes(2, 6);
            binaryTree.Root.Left.AddChildNodes(1, 3);
            binaryTree.Root.Right.AddChildNodes(5, 7);
            return binaryTree;
        }
    }
}
