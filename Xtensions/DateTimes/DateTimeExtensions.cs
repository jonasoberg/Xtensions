using System;
using System.Collections.Generic;
using System.Text;

namespace Vorticity.Xtensions.DateTimes {
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
        public static bool IsWithinTimeSpan(this DateTime self, DateTime compare, TimeSpan ts) {
            var diff_ms = Math.Abs(self.Subtract(compare).TotalMilliseconds);
            if (diff_ms <= ts.TotalMilliseconds) {
                return true;
            } else {
                return false;
            }

        }

        public static long ToEpochLong(this DateTime? self) {
            if (self.HasValue == false || self.Value == null) {
                return 0;
            }
            return self.Value.ToEpochLong();
        }
        public static long ToEpochLong(this DateTime self) {
            if (self == null) {
                return 0;
            }
            DateTimeOffset dto = new DateTimeOffset(self, TimeSpan.FromTicks(0));
            return dto.ToUnixTimeSeconds();
        }


    }
}
