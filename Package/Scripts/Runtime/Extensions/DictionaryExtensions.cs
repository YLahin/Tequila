using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine.Assertions;

namespace Tequila.Extensions
{
    [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
    public static class DictionaryExtensions
    {
        public static void AddRange<TKey, TValue>(this IDictionary<TKey, TValue> self, IEnumerable<KeyValuePair<TKey, TValue>> keyValuePairs, bool overwrite = false)
        {
            Assert.IsNotNull(self);
            Assert.IsNotNull(keyValuePairs);

            foreach (var keyValuePair in keyValuePairs)
            {
                if (overwrite)
                {
                    self[keyValuePair.Key] = keyValuePair.Value;
                }
                else
                {
                    self.Add(keyValuePair.Key, keyValuePair.Value);
                }
            }
        }

        public static int RemoveRange<TKey, TValue>(this IDictionary<TKey, TValue> self, IEnumerable<TKey> keys)
        {
            Assert.IsNotNull(self);
            Assert.IsNotNull(keys);

            var result = 0;

            foreach (var key in keys)
            {
                if (self.Remove(key))
                {
                    result++;
                }
            }

            return result;
        }

        public static bool TryPullValue<TKey, TValue>(this IDictionary<TKey, TValue> self, TKey key, out TValue value)
        {
            Assert.IsNotNull(self);

            if (!self.TryGetValue(key, out value))
            {
                return false;
            }

            self.Remove(key);

            return true;
        }
    }
}
