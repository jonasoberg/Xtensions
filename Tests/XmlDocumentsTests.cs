using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Xtensions.XmlDocuments;
namespace Tests {
    [TestFixture]
    public class XmlDocumentsTests {

        [Test]
        public void Test_XmlDocument_AddXmlDeclaration() {
            var x = new XmlDocument();
            var y = x.AddXmlDeclaration();

            Assert.AreEqual(y.OuterXml, x.OuterXml);

            var root = x.AddChildElement("data");
            root.AddChildElement("e1").InnerText = "test1";
            root.AddChildElement("e2").InnerText = "test2";
            root.AddChildElement("e3").InnerText = "test3";
            root.AddChildElement("e4").InnerText = "test4";

            var m_OuterXml = x.OuterXml;

            /*
             <?xml version="1.0" encoding="UTF-8" standalone="true"?>
                <data>
                    <e1>test1</e1>
                    <e2>test2</e2>
                    <e3>test3</e3>
                    <e4>test4</e4>
                </data>
            */
            var xml =  XElement.Parse(m_OuterXml);

            var actual = xml.Descendants().Where(m => m.Name.LocalName == "e3").Select(m => m.Value).SingleOrDefault();
            Assert.AreEqual("test3", actual);
        }
    }
}
