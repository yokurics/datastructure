using DataStructure.Extentions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DataStructure.Tests
{
    [TestClass]
    public class TestMyArrayExtensions
    {
        [TestMethod]
        public void TestIterativeBinarySearch()
        {
            var items = new int[] { 1, 3, 5, 7, 9, 11 };
            var values = new int[] { 3, 7, 9, 11 };
            var expecteds = new int[] { 1, 3, 4, 5 };
            var actuals = new int[4];

            for (var i = 0; i < values.Length; i++)
            {
                actuals[i] = items.IterativeBinarySearch(values[i], 0, items.Length);
            }
            
            Assert.AreEqual(expecteds.Length, actuals.Length);
            CollectionAssert.AreEqual(expecteds, actuals);
        }

        [TestMethod]
        public void TestRecursiveBinarySearch()
        {
            var items = new int[] { 1, 3, 5, 7, 9, 11 };
            var value = 5;
            var expected = 2;
            var actual = items.RecursiveBinarySearch(value, 0, items.Length);
            Assert.AreEqual(expected, actual);
        }
    }
}
