using System;
using System.Collections.Generic;
using System.Text;

namespace Xtensions.Numerical
{
    public static class NumericalExtensions
    {
        public static bool IsBetween(this int? value, int start, int end) {
            if(value.HasValue == false) {
                return false;
            }

            return value.Value.IsBetween(start, end);
        }
        public static bool IsBetween(this int value, int start, int end) {
            return Comparer<int>.Default.Compare(value, start) >= 0 && Comparer<int>.Default.Compare(value, end) <= 0;
        }
    }
}
