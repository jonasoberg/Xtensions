using NUnit.Framework;
using System.Diagnostics;
using System.Xml.Linq;
using Xtensions.XElements;
namespace UnitTests
{
    [TestFixture]
    public class XElementTests
    {
        [Test]
        public void Test_XElement_AddElement() {
            var t = (new XElement("data"))
                .AddElement(
                    (new XElement("test1", "test1")).AddAttribute("test4", "test4")
                    )
                .AddElement(new XElement("test2", "test2"))
                .AddAttribute(new XAttribute("test3", "test3"));

            var tt = @"<data test3=""test3""><test1 test4=""test4"">test1</test1><test2>test2</test2></data>";

            Assert.AreEqual(tt, t.ToString(SaveOptions.DisableFormatting));
        }
        [Test]
        public void Test_XElement_AddAttributet() {
            var t = (new XElement("test", "test")).AddAttribute("test4", "test4");
            var tt = @"<test test4=""test4"">test</test>";
            Assert.AreEqual(tt, t.ToString(SaveOptions.DisableFormatting));
        }
    }
}
