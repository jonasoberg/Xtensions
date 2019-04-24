using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vorticity.Xtensions.DateTimes;
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

        [Test]
        public void Test_DateTime_Seconds() {
            Assert.AreEqual(60000, 60.Seconds().TotalMilliseconds, "Seconds() returns wrong timespan");
        }
        [Test]
        public void Test_DateTime_Minutes() {
            Assert.AreEqual(300, 5.Minutes().TotalSeconds, "Minutes() returns wrong timespan");
        }
        [Test]
        public void Test_DateTime_Hours() {
            Assert.AreEqual(7200, 2.Hours().TotalSeconds, "Hours() returns wrong timespan");
        }
        [Test]
        public void Test_DateTime_IsWithinTimeSpan() {

            var dte = DateTime.UtcNow;
            var dte2 = dte.AddSeconds(2);

            Assert.IsTrue(dte.IsWithinTimeSpan(dte2, TimeSpan.FromSeconds(5)), "IsWithinTimeSpan Expected to return true");

            Assert.IsFalse(dte.IsWithinTimeSpan(dte2, TimeSpan.FromSeconds(1)), "IsWithinTimeSpan Expected to return false");
        }

        [Test]
        public void Test_DateTime_ToEpochLong() {

            var dte = DateTime.UtcNow;

            var epoch = dte.ToEpochLong();
            
            Assert.IsTrue(epoch > 1500000000, "Epoxh expected to be larger than 1500000000");
        }


    }
}
