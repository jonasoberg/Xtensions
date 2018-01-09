using System;
using System.Collections.Generic;
using System.Text;

namespace Xtensions.Binary
{
    public static class BinaryExtensions
    {
        public static string ToBase64String(this byte[] self) {
            if(self == null || self.Length == 0) {
                return String.Empty;
            }
            return Convert.ToBase64String(self);
        }
        public static byte[] FromBase64String(this string self) {
            if(String.IsNullOrEmpty(self)) {
                return null;
            }
            return Convert.FromBase64String(self);
        }
    }
}
