using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xtensions;
using System.Collections.Generic;

namespace Tests {
    [TestClass]
    public class StringsTests {
        [TestMethod]
        public void Test_String_ToInt32() {

            var tests = new List<Tuple<string, int>>();
            tests.Add(new Tuple<string, int>("1", 1));
            tests.Add(new Tuple<string, int>("-1", -1));
            tests.Add(new Tuple<string, int>("123", 123));

            tests.Add(new Tuple<string, int>("hello", 0));
            tests.Add(new Tuple<string, int>("", 0));
            tests.Add(new Tuple<string, int>(null, 0));


            tests.ForEach(t => Assert.IsTrue(t.Item1.ToInt32() == t.Item2, $"could not parse string '{t.Item1}' to int32: {t.Item2}"));

        }
        [TestMethod]
        public void Test_String_IsNullOrEmpty() {
            Assert.IsTrue(((string)null).IsNullOrEmpty() == true);
            Assert.IsTrue("".IsNullOrEmpty() == true);
            Assert.IsTrue("hello".IsNullOrEmpty() == false);
        }
        [TestMethod]
        public void Test_String_ToNotNull() {
            string str = null;
            Assert.IsTrue(str.ToNotNull().Length == 0, "");
            str = "hello";
            Assert.IsTrue(str.ToNotNull() == str, "");
        }
    }

    [TestClass]
    public class CollectionsTests {
        [TestMethod]
        public void Test_GetItemOrDefault() {
            Dictionary<string, int> v = new Dictionary<string, int>() {
                { "1",1 },
                { "2",2 },
                { "3",3 },
            };

            Assert.IsTrue(v.GetItemOrDefault("1") == 1, "");
            Assert.IsTrue(v.GetItemOrDefault("4") == 0, "");

            Dictionary<string, object> v2 = new Dictionary<string, object>() {
                { "1",1 },
                { "2",null },
                { "3","hello" },
            };

            Assert.IsTrue(v2.GetItemOrDefault("1") is 1, "");
            Assert.IsTrue(v2.GetItemOrDefault("2") is null, "");
            Assert.IsTrue(v2.GetItemOrDefault("3") is "hello", "");
            Assert.IsTrue(v2.GetItemOrDefault("4") is null, "");

        }
    }
}
