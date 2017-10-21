using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xtensions;
namespace Tests {
    [TestFixture]
    public class DateTimeTests {
        [Test]
        public void Test_DateTime_ToDateKey() {
            DateTime dte = new DateTime(2015, 10, 21);
            Assert.AreEqual(20151021, dte.ToDateKey(), "ToDateKey returns wrong int");
        }
        [Test]
        public void Test_DateTime_ToTimeKey() {
            DateTime dte = new DateTime(2015, 10, 21, 16, 29, 0);
            Assert.AreEqual(1629, dte.ToTimeKey(), "ToTimeKey returns wrong int");
        }
    }
}
