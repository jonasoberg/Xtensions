using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xtensions;
using System.Collections.Generic;

namespace Tests {

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
