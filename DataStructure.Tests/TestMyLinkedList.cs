using DataStructure.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DataStructure.Tests
{
    [TestClass]
    public class TestMyLinkedList
    {
        [TestMethod]
        public void TestAddFirst()
        {
            var expected = "foo";
            var inputs = new string[] { "node0", "node1", "node2", "node3" };
            var items = new MyLinkedList<string>();

            for (var i = 0; i < inputs.Length; i++)
            {
                if (i == 2)
                {
                    items.AddFirst("foo");
                }

                items.AddLast(inputs[i]);
            };

            var actual = items.First.Value;

            Assert.AreEqual(expected, actual);
            PrintItemValues(items);
        }

        [TestMethod]
        public void TestAddLast()
        {
            var expected = "foo";
            var inputs = new string[] { "node0", "node1", "node2", "node3" };
            var items = new MyLinkedList<string>();

            for (var i = 0; i < inputs.Length; i++)
            {
                if (i == 2)
                {
                    items.AddLast("foo");
                }

                items.AddFirst(inputs[i]);
            };

            var actual = items.Last.Value;

            Assert.AreEqual(expected, actual);
            PrintItemValues(items);
        }

        [TestMethod]
        public void TestCount()
        {
            var expected = 4;
            var inputs = new string[] { "node0", "node1", "node2", "node3" };
            var items = new MyLinkedList<string>();

            for (var i = 0; i < inputs.Length; i++)
            {
                items.AddLast(inputs[i]);
            };

            var actual = items.Count;

            Assert.AreEqual(expected, actual);
        }

        public void PrintItemValues<T>(MyLinkedList<T> items) // for debug
        {
            for (var node = items.First; node != null; node = node.Next)
            {
                Console.WriteLine(node.Value);
            }
        }
    }
}
