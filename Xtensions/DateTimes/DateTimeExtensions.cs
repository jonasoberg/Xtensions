using System;
using System.Collections.Generic;
using System.Text;

namespace Xtensions.DateTimes {
    public static class DateTimeExtensions
    {
        public static int ToDateKey(this System.DateTime self, int defaultValue = 0) {
            if(self == null)
                return defaultValue;

            return
                self.Year * 10000 +
                self.Month * 100 +
                self.Day;
        }
        public static int ToTimeKey(this System.DateTime self, int defaultValue = 0) {
            if(self == null)
                return defaultValue;

            return
                self.Hour * 100 +
                self.Minute;
        }

        public static TimeSpan Hours(this int self) {
            return new TimeSpan(self, 0, 0);
        }
        public static TimeSpan Minutes(this int self) {
            return new TimeSpan(0, self, 0);
        }
        public static TimeSpan Seconds(this int self) {
            return new TimeSpan(0, 0, self);
        }
    }
}
