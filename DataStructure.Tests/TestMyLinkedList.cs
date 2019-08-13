using DataStructure.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            var currentNode = items.End;

            for (var i = 0; i < inputs.Length; i++)
            {
                if (i == 2)
                {
                    items.AddFirst("foo");
                }

                currentNode = items.AddAfter(currentNode, inputs[i]);
            };

            var actual = items.First.Value;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAddLast()
        {
            var expected = "foo";
            var inputs = new string[] { "node0", "node1", "node2", "node3" };
            var items = new MyLinkedList<string>();
            var currentNode = items.End;

            for (var i = 0; i < inputs.Length; i++)
            {
                if (i == 2)
                {
                    items.AddLast("foo");
                }

                currentNode = items.AddAfter(currentNode, inputs[i]);
            };

            var actual = items.Last.Value;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCount()
        {
            var expected = 4;
            var inputs = new string[] { "node0", "node1", "node2", "node3" };
            var items = new MyLinkedList<string>();
            var currentNode = items.End;

            for (var i = 0; i < inputs.Length; i++)
            {
                currentNode = items.AddAfter(currentNode, inputs[i]);
            };

            var actual = items.Count;

            Assert.AreEqual(expected, actual);
        }
    }
}
