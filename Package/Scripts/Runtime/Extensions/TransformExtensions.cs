using System.Collections.Generic;
using System.IO;
using System.Linq;
using Tequila.Scopes;
using UnityEngine;
using UnityEngine.Assertions;

namespace Tequila.Extensions
{
    public static class TransformExtensions
    {
        public static bool TryGetChild(this Transform self, int index, out Transform child)
        {
            Assert.IsNotNull(self);

            if (index >= self.childCount)
            {
                child = default;

                return false;
            }

            child = self.GetChild(index);

            return child != null;
        }

        public static string GetHierarchyPath(this Transform self)
        {
            Assert.IsNotNull(self);

            var names = self
                .GetHierarchyTransforms()
                .Select(transform => transform.name);

            return string.Join(Path.AltDirectorySeparatorChar.ToString(), names);
        }

        public static IEnumerable<Transform> GetHierarchyTransforms(this Transform self)
        {
            Assert.IsNotNull(self);

            using (StackScope<Transform>.Create(out var transforms))
            {
                for (var transform = self; transform != null; transform = transform.parent)
                {
                    transforms.Push(transform);
                }

                while (transforms.Count > 0)
                {
                    yield return transforms.Pop();
                }
            }
        }
    }
}
