using System.Collections.Generic;
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

            return self.gameObject.GetOrAddComponent<T>();
        }

        public static bool HasComponent<T>(this Component self)
            where T : class
        {
            Assert.IsNotNull(self);

            return self.gameObject.TryGetComponent(out T _);
        }

        public static bool TryGetComponentInChildren<T>(this Component self, out T component, bool includeInactive = false)
            where T : class
        {
            Assert.IsNotNull(self);

            return self.gameObject.TryGetComponentInChildren(out component, includeInactive);
        }

        public static bool TryGetComponentInParent<T>(this Component self, out T component, bool includeInactive = false)
            where T : class
        {
            Assert.IsNotNull(self);

            return self.gameObject.TryGetComponentInParent(out component, includeInactive);
        }

        public static int TryGetComponentsInChildren<T>(this Component self, ICollection<T> components, bool includeInactive = false)
            where T : class
        {
            Assert.IsNotNull(self);
            Assert.IsNotNull(components);
            Assert.IsTrue(components.Count == 0);

            return self.gameObject.TryGetComponentsInChildren(components, includeInactive);
        }

        public static int TryGetComponentsInParent<T>(this Component self, ICollection<T> components, bool includeInactive = false)
            where T : class
        {
            Assert.IsNotNull(self);
            Assert.IsNotNull(components);
            Assert.IsTrue(components.Count == 0);

            return self.gameObject.TryGetComponentsInParent(components, includeInactive);
        }
    }
}
