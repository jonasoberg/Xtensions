using System;
using Xtensions;
using System.Collections.Generic;
using NUnit.Framework;

namespace Tests {

    [TestFixture]
    public class CollectionsTests {
        [Test]
        public void Test_GetItemOrDefault() {
            Dictionary<string, int> v = new Dictionary<string, int>() {
                { "1",1 },
                { "2",2 },
                { "3",3 },
            };

            Assert.AreEqual(1, v.GetItemOrDefault("1"));
            Assert.AreEqual(0, v.GetItemOrDefault("4"));

            Dictionary<string, object> v2 = new Dictionary<string, object>() {
                { "1",1 },
                { "2",null },
                { "3","hello" },
            };

            Assert.AreEqual(1, v2.GetItemOrDefault("1"));
            Assert.AreEqual(null, v2.GetItemOrDefault("2"));
            Assert.AreEqual("hello", v2.GetItemOrDefault("3"));
            Assert.AreEqual(null, v2.GetItemOrDefault("4"));

        }
        [Test]
        public void Test_StringList_Join() {
            List<string> t1 = null;
            Assert.AreEqual(String.Empty, t1.Join(";"));

            List<string> t2 = new List<string>() { "1", "2" };
            Assert.AreEqual("1;2", t2.Join(";"));

            List<string> t3 = new List<string>() { "1", null };
            Assert.AreEqual("1;", t3.Join(";"));


        }
    }
}
