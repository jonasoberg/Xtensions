using System;
using System.Collections.Generic;
using System.Linq;
namespace Xtensions.Strings
{
    public static class StringExtensions {
        #region Numeric

        public static int ToInt32(this string self, int defaultValue = 0) {
            if(String.IsNullOrEmpty(self)) {
                return defaultValue;
            }
            int ret = defaultValue;
            if(int.TryParse(self, out ret)) {
                return ret;
            } else {
                return defaultValue;
            }
        }
        public static decimal ToDecimal(this string self, decimal defaultValue = 0) {
            if(String.IsNullOrEmpty(self)) {
                return defaultValue;
            }
            decimal ret = defaultValue;
            if(decimal.TryParse(self, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out ret)) {
                return ret;
            } else {
                return defaultValue;
            }
        }
        public static double ToDouble(this string self, double defaultValue = 0) {
            if(String.IsNullOrEmpty(self)) {
                return defaultValue;
            }
            double ret = defaultValue;
            if(double.TryParse(self, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out ret)) {
                return ret;
            } else {
                return defaultValue;
            }
        }

        public static Guid ToGuid(this string self) {
            if(self.IsNullOrEmpty()) {
                return Guid.Empty;
            }
            Guid g = Guid.Empty;
            if(Guid.TryParse(self, out g)) {
                return g;
            } else {
                return Guid.Empty;
            }
        }
        #endregion

        #region String operations
        public static string Left(this string self, int length) {
            if(self.IsNullOrEmpty()) {
                return String.Empty;
            }
            if(self.Length <= length) {
                return self;
            } else {
                return self.Substring(0, length);
            }
        }

        public static string Right(this string self, int length) {
            if(self.IsNullOrEmpty()) {
                return String.Empty;
            }
            if(self.Length <= length) {
                return self;
            } else {
                return self.Substring(self.Length - length, length);
            }
        }

        #endregion

        #region null
        public static bool IsNullOrEmpty(this string self) {
            return String.IsNullOrEmpty(self);
        }
        public static string ToNotNull(this string self) {
            if(String.IsNullOrEmpty(self)) {
                return String.Empty;
            } else {
                return self;
            }
        }
        #endregion
        public static List<int> ToListOfInt32(this string self, char delimiter = ';') {
            if(self.IsNullOrEmpty()) {
                return new List<int>();
            }
            return self
                .Split(delimiter)
                .Where(m => m.IsNullOrEmpty() == false)
                .Select(m => m.ToInt32())
                .ToList();
        }

        public static string Repeat(this string self, int count) {
            count = Math.Max(count, 0);
            return String.Join(String.Empty, Enumerable.Range(0, count).Select(m => self.ToString()).ToArray());
        } 

    }
}
