using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xtensions.Numerical;
namespace Tests {
    [TestFixture]
    public class NumericalExtensionsTests {
        [Test]
        public void Test_IsBetween(){

            Assert.AreEqual(true, 5.IsBetween(0, 10));
            Assert.AreEqual(false, 50.IsBetween(0, 10));
            Assert.AreEqual(true, 5.IsBetween(0, 5));

            Assert.AreEqual(true, ((int?)5).IsBetween(0, 10));
            Assert.AreEqual(false, ((int?)50).IsBetween(0, 10));
            Assert.AreEqual(false, ((int?)null).IsBetween(0, 10));
        }
    }
}
