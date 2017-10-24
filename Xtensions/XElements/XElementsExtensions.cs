using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Xtensions.XElements
{
    public static class XElementsExtensions
    {
        public static XElement AddElement(this XElement self, XElement element) {
            if(self == null) {
                self = new XElement("new");
            }

            self.Add(element);
            return self;
        }
        public static XElement AddAttribute(this XElement self, XAttribute attribute) {
            if(self == null) {
                self = new XElement("new");
            }

            self.Add(attribute);
            return self;
        }
        public static XElement AddAttribute(this XElement self, string attributeName, string attributeValue) {
            if(self == null) {
                self = new XElement("new");
            }

            self.Add(new XAttribute(attributeName, attributeValue));
            return self;
        }
    }
}
