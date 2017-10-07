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
    }
}
