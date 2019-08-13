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
            var expected = "node1";
            var input1 = "node1";
            var input2 = "node2";
            var items = new MyLinkedList<string>();
            var node1 = items.AddFirst(input1);
            items.AddAfter(node1, input2);
            var actual = items.First.Value;

            Assert.AreEqual(expected, actual);
        }
    }
}
