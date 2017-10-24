using System;
using System.Collections.Generic;
using System.Text;

namespace Xtensions.Collections {
    public static class CollectionsExtensions
    {
        public static T GetItemOrDefault<T>(this Dictionary<string, T> self, string key) {
            if(self == null) {
                return default(T);
            }

            if(self.ContainsKey(key)) {
                return self[key];
            } else {
                return default(T);
            }
        }
        public static void AddOrReplace<T>(this Dictionary<string, T> self, string key, T value) {
            if(self == null)
                return;

            if(self.ContainsKey(key)) {
                self[key] = value;
            } else {
                self.Add(key, value);
            }
        }

        public static string Join(this IEnumerable<string> self, string delimiter) {
            if(self == null) {
                return String.Empty;
            }

            return String.Join(delimiter, self);
        }

    }
}
