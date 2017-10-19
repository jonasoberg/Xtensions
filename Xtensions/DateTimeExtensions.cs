using System;
using System.Collections.Generic;
using System.Text;

namespace Xtensions
{
    public static class DateTimeExtensions
    {
        public static int ToDateKey(this DateTime self, int defaultValue = 0) {
            if(self == null)
                return defaultValue;

            return
                self.Year * 1000000 +
                self.Month * 100 +
                self.Day;
        }
        public static int ToTimeKey(this DateTime self, int defaultValue = 0) {
            if(self == null)
                return defaultValue;

            return
                self.Hour * 100 +
                self.Minute;
        }
    }
}
