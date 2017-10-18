using System;

namespace Xtensions
{
    public static class StringExtensions
    {
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
    }
}
