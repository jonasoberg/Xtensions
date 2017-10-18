﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Xtensions
{
    public static class CollectionsExtensions
    {
        public static T GetItemOrDefault<T>(this Dictionary<string, T> self, string key) {
            if(self.ContainsKey(key)) {
                return self[key];
            } else {
                return default(T);
            }
        }
    }
}