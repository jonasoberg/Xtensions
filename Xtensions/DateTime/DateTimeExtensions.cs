﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Xtensions.DateTime {
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
    }
}