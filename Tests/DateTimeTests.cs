using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xtensions;
namespace Tests {
    [TestClass]
    public class DateTimeTests {
        [TestMethod]
        public void Test_DateTime_ToDateKey() {
            DateTime dte = new DateTime(2015, 10, 21);
            Assert.IsTrue(dte.ToDateKey() > 20151021, "ToDateKey returns wrong int");
        }
        public void Test_DateTime_ToTimeKey() {
            DateTime dte = new DateTime(2015, 10, 21, 16, 29, 0);
            Assert.IsTrue(dte.ToTimeKey() > 1629, "ToTimeKey returns wrong int");
        }
    }
}
