using System;
using DataStructure.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructure.Tests
{
    [TestClass]
    public class TestMyStack
    {
        [TestMethod]
        public void TestPush()
        {
            var expecteds = new string[] { "node3", "node2" };
            var inputs = new string[] { "node0", "node1", "node2", "node3" };
            var items = new MyStack<string>();

            for (var i = 0; i < inputs.Length; i++)
            {
                items.Push(inputs[i]);
            };

            var actuals = new string[2];

            for (var i = 0; i < actuals.Length; i++)
            {
                actuals[i] = items.Pop();
            }

            CollectionAssert.AreEqual(expecteds, actuals);
        }
    }
}
