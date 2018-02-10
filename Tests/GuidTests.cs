using System;
using Xtensions.Strings;
using Xtensions.Guids;
using System.Collections.Generic;
using NUnit.Framework;

namespace Tests {
    [TestFixture]
    public class GuidTests {
        [Test]
        public void Test_Guid_Str() {
            var e = "00000000-0000-0000-0000-000000000000";
            var _e = "00000000000000000000000000000000";
            Assert.AreEqual(e, Guid.Empty.Str(), "Empty Guids were not equal");
            Assert.AreEqual(_e, Guid.Empty.Str(true), "Empty Guids were not equal");
        }
    }
}
