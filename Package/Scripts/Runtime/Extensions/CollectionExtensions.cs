using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine.Assertions;

namespace Tequila.Extensions
{
    [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
    public static class CollectionExtensions
    {
        public static void AddRange<T>(this ICollection<T> self, IEnumerable<T> items)
        {
            Assert.IsNotNull(self);
            Assert.IsNotNull(items);

            foreach (var item in items)
            {
                self.Add(item);
            }
        }

        public static void RemoveRange<T>(this ICollection<T> self, IEnumerable<T> items)
        {
            Assert.IsNotNull(self);
            Assert.IsNotNull(items);

            foreach (var item in items)
            {
                self.Remove(item);
            }
        }
    }
}
