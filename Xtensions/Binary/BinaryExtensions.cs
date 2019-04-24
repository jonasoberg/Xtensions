using System;
using System.Collections.Generic;
using System.Text;

namespace Vorticity.Xtensions.Binary
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

        public static byte[] ToByteArray(this string self) {
            if (String.IsNullOrEmpty(self)) {
                return new byte[0];
            }
            return Encoding.UTF8.GetBytes(self);
        }

        public static string StringFromByteArray(this byte[] self) {
            if (self == null) {
                return String.Empty;
            }
            return System.Text.Encoding.UTF8.GetString(self);
        }

    }
}
