using DataStructure.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;

namespace DataStructure.Tests
{
    [TestClass]
    public class TestMyHashtable
    {
        [TestMethod]
        public void TestGetValue()
        {
            var expected = "bar2";
            var table = new MyHashtable<string, string>();
            table["foo"] = "bar";
            table["foo"] = "bar2";

            var actual = table.GetValue("foo");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetHashKey()
        {
            var inputs = new string[10] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
            var table = new MyHashtable<string, string>();

            for (var i = 0; i < inputs.Length; i++)
            {
                Console.WriteLine(string.Format("{0}={1}", inputs[i], table.GetHashKey(inputs[i])));
            }

            Assert.IsTrue(true);
        }
    }
}
