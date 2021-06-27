using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Tequila.Scopes;
using UnityEngine.Assertions;

namespace Tequila.Extensions
{
    [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> Cache<T>(this IEnumerable<T> self)
        {
            Assert.IsNotNull(self);

            using (ListScope<T>.Create(out var items))
            {
                items.AddRange(self);

                foreach (var item in items)
                {
                    yield return item;
                }
            }
        }

        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> self, Action<T> action)
        {
            Assert.IsNotNull(self);
            Assert.IsNotNull(action);

            foreach (var item in self)
            {
                action(item);
            }

            return self;
        }

        public static bool TryGetFirstOrDefault<T>(this IEnumerable<T> self, out T value)
        {
            Assert.IsNotNull(self);

            foreach (var item in self)
            {
                value = item;

                return true;
            }

            value = default;

            return false;
        }

        public static bool TryGetFirstOrDefault<T>(this IEnumerable<T> self, Predicate<T> predicate, out T value)
        {
            Assert.IsNotNull(self);
            Assert.IsNotNull(predicate);

            foreach (var item in self)
            {
                if (!predicate(item))
                {
                    continue;
                }

                value = item;

                return true;
            }

            value = default;

            return false;
        }
    }
}
