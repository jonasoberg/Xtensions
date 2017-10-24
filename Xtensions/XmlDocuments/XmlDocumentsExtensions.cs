using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Xtensions.XmlDocuments
{
    public static class XmlDocumentsExtensions
    {
        public static XmlDocument AddXmlDeclaration(this XmlDocument self, string version = "1.0", string encoding = "utf-8", string standalone = "yes") {
            var decl = self.CreateXmlDeclaration(version, encoding, standalone);
            self.AppendChild(decl);
            return self;
        }
        public static XmlNode AddChildElement(this XmlNode self, string elementName) {
            var e = self.OwnerDocument == null ? ((XmlDocument)self).CreateElement(elementName) : self.OwnerDocument.CreateElement(elementName);
            self.AppendChild(e);
            return e;
        }
    }
}
