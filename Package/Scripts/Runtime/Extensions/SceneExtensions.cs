using System.Collections.Generic;
using Tequila.Scopes;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;

namespace Tequila.Extensions
{
    public static class SceneExtensions
    {
        public static bool TryGetComponentInChildren<T>(this Scene self, out T component, bool includeInactive = false)
            where T : class
        {
            using (ListScope<GameObject>.Create(out var rootGameObjects))
            {
                self.GetRootGameObjects(rootGameObjects);

                foreach (var rootGameObject in rootGameObjects)
                {
                    if (rootGameObject.TryGetComponentInChildren(out component, includeInactive))
                    {
                        return true;
                    }
                }

                component = default;

                return false;
            }
        }

        public static int TryGetComponentsInChildren<T>(this Scene self, ICollection<T> components, bool includeInactive = false)
            where T : class
        {
            Assert.IsNotNull(components);
            Assert.IsTrue(components.Count == 0);

            using (ListScope<GameObject>.Create(out var rootGameObjects))
            using (ListScope<T>.Create(out var results))
            {
                self.GetRootGameObjects(rootGameObjects);

                foreach (var rootGameObject in rootGameObjects)
                {
                    if (rootGameObject.TryGetComponentsInChildren(results, includeInactive) > 0)
                    {
                        components.AddRange(results);
                    }
                }

                return results.Count;
            }
        }
    }
}
