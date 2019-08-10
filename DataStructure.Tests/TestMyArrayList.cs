using DataStructure.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructure.Tests
{
    [TestClass]
    public class TestMyArrayList
    {
        [TestMethod]
        public void TestAddFirst()
        {
            var expected = "hoge";
            var input = "hoge";
            var items = new MyArrayList<string>(new string[] { "a", "b", "c" });
            items.AddFirst(input);
            var actual = items.First();
            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAddLast()
        {
            var expected = "hoge";
            var input = "hoge";
            var items = new MyArrayList<string>(new string[] { "a", "b", "c" });
            items.AddLast(input);
            var actual = items.Last();

            Assert.AreEqual(expected, actual);
        }
    }
}
