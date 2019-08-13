using DataStructure.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Tests
{
    [TestClass]
    public class TestMyLinkedList
    {
        [TestMethod]
        public void TestAddFirst()
        {
            var expected = "node0";
            var inputs = new string[] { "node0", "node1" };
            var items = new MyLinkedList<string>();
            var node0 = items.AddFirst(inputs[0]);
            items.AddAfter(node0, inputs[1]);
            var actual = items.First.Value;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAddLast()
        {
            var expected = "node3";
            var inputs = new string[] { "node0", "node1", "node2", "node3" };
            var items = new MyLinkedList<string>();
            var node0 = items.AddFirst(inputs[0]);
            items.AddLast(inputs[inputs.Length - 1]);
            var node1 = items.AddAfter(node0, inputs[1]);
            var node2 = items.AddAfter(node1, inputs[2]);
            var actual = items.Last.Value;

            Assert.AreEqual(expected, actual);
        }
    }
}
