using System.Collections.Generic;
using Tequila.Scopes;
using UnityEngine;
using UnityEngine.Assertions;

namespace Tequila.Extensions
{
    public static class ComponentExtensions
    {
        public static T GetOrAddComponent<T>(this Component self)
            where T : Component
        {
            Assert.IsNotNull(self);

            return self.TryGetComponent(out T component)
                ? component
                : self.gameObject.AddComponent<T>();
        }

        public static bool HasComponent<T>(this Component self)
            where T : class
        {
            return self.TryGetComponent(out T _);
        }

        public static bool TryGetComponentInChildren<T>(this Component self, out T component)
            where T : class
        {
            Assert.IsNotNull(self);

            component = self.GetComponentInChildren<T>();

            return component != null;
        }

        public static bool TryGetComponentInParent<T>(this Component self, out T component)
            where T : class
        {
            Assert.IsNotNull(self);

            component = self.GetComponentInParent<T>();

            return component != null;
        }

        public static int TryGetComponentsInChildren<T>(this Component self, ICollection<T> components, bool includeInactive = false)
            where T : class
        {
            Assert.IsNotNull(self);
            Assert.IsNotNull(components);
            Assert.IsTrue(components.Count == 0);

            using (ListScope<T>.Create(out var results))
            {
                self.GetComponentsInChildren(includeInactive, results);
                components.AddRange(results);

                return results.Count;
            }
        }

        public static int TryGetComponentsInParent<T>(this Component self, ICollection<T> components, bool includeInactive = false)
            where T : class
        {
            Assert.IsNotNull(self);
            Assert.IsNotNull(components);
            Assert.IsTrue(components.Count == 0);

            using (ListScope<T>.Create(out var results))
            {
                self.GetComponentsInParent(includeInactive, results);
                components.AddRange(results);

                return results.Count;
            }
        }
    }
}
