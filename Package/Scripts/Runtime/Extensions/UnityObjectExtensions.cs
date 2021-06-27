using UnityEngine;
using UnityEngine.Assertions;

namespace Tequila.Extensions
{
    public static class UnityObjectExtensions
    {
        public static void Destroy(this Object self)
        {
            Assert.IsNotNull(self);

            Object.Destroy(self);
        }

        public static void DestroyImmediate(this Object self)
        {
            Assert.IsNotNull(self);

            Object.DestroyImmediate(self);
        }

        public static T Instantiate<T>(this T self)
            where T : Object
        {
            Assert.IsNotNull(self);

            return Object.Instantiate(self);
        }

        public static T Instantiate<T>(this T self, Transform parent)
            where T : Object
        {
            Assert.IsNotNull(self);

            return Object.Instantiate(self, parent);
        }

        public static T Instantiate<T>(this T self, Transform parent, Vector3 position)
            where T : Object
        {
            Assert.IsNotNull(self);

            return Object.Instantiate(self, position, Quaternion.identity, parent);
        }

        public static T WithName<T>(this T self, string name)
            where T : Object
        {
            Assert.IsNotNull(self);
            Assert.IsFalse(string.IsNullOrWhiteSpace(name));

            self.name = name;

            return self;
        }

        public static T WithHideFlags<T>(this T self, HideFlags hideFlags)
            where T : Object
        {
            Assert.IsNotNull(self);

            self.hideFlags = hideFlags;

            return self;
        }
    }
}
