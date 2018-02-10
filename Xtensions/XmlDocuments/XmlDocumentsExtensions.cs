using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Vorticity.Xtensions.XmlDocuments
{
    public static class XmlDocumentsExtensions
    {
        public static XmlDocument AddXmlDeclaration(this XmlDocument self, string version = "1.0", string encoding = "utf-8", string standalone = "yes") {
            var decl = self.CreateXmlDeclaration(version, encoding, standalone);
            self.AppendChild(decl);
            return self;
        }

        public static XmlDocument AddComment(this XmlDocument self, string commentText) {
            var comment = self.CreateComment(commentText);
            self.AppendChild(comment);
            return self;
        }

        public static XmlNode AddChildElement(this XmlNode self, string elementName, string innerText = null) {
            var e = self.OwnerDocument == null ? ((XmlDocument)self).CreateElement(elementName) : self.OwnerDocument.CreateElement(elementName);
            if(innerText != null) {
                e.InnerText = innerText;
            }
            self.AppendChild(e);
            return e;
        }
        public static XmlNode AddAttribute(this XmlNode self, string attributeName, string innerText = null) {
            var a = self.OwnerDocument == null ? ((XmlDocument)self).CreateAttribute(attributeName) : self.OwnerDocument.CreateAttribute(attributeName);
            if(innerText != null) {
                a.Value = innerText;
            }
            self.Attributes.Append(a);
            return self;
        }
    }
}
