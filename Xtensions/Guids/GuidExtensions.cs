using System;
using System.Collections.Generic;
using System.Text;

namespace Vorticity.Xtensions.Guids
{
    public static class GuidExtensions {
        /// <summary>
        /// Guid to string
        /// </summary>
        /// <param name="self"></param>
        /// <param name="removeDash"></param>
        /// <returns></returns>
        public static string Str(this Guid self, bool removeDash = false) {
            if(self == null) {
                return String.Empty;
            }
            if(removeDash) {
                return self.ToString().ToLower().Replace("-", "");
            } else {
                return self.ToString().ToLower();
            }
        }

    }
}
