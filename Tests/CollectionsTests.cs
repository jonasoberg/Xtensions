using System;
using Xtensions.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace Tests {

    [TestFixture]
    public class CollectionsTests {
        [Test]
        public void Test_Collections_GetItemOrDefault() {
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
        public void Test_Collections_AddOrReplace() {
            Dictionary<string, object> d = new Dictionary<string, object>();
            d.Add("1", null);
            d.AddOrReplace("1", 1);
            Assert.AreEqual(1, d["1"]);

            d.AddOrReplace("2", 2);
            Assert.AreEqual(2, d["2"]);

            d.AddOrReplace("2", null);
            Assert.AreEqual(null, d["2"]);

            d = null;
            d.AddOrReplace("1", 1);
            Assert.AreEqual(null, d);
        }

        [Test]
        public void Test_Collections_StringList_Join() {
            List<string> t1 = null;
            Assert.AreEqual(String.Empty, t1.Join(";"));

            List<string> t2 = new List<string>() { "1", "2" };
            Assert.AreEqual("1;2", t2.Join(";"));

            List<string> t3 = new List<string>() { "1", null };
            Assert.AreEqual("1;", t3.Join(";"));
        }




        [Test]
        public void Test_Collections_PropertiesToDictionary() {
            var raw = new {
                TestValue = "TEST"
            };
            var expected = new Dictionary<string, string>() { { "TestValue", "TEST" } };

            Assert.AreEqual(expected, raw.PropertiesToDictionary());
        }

    }
}
