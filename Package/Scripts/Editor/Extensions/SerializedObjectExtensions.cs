using System.Collections.Generic;
using UnityEditor;
using UnityEngine.Assertions;

namespace Tequila.Extensions
{
    public static class SerializedObjectExtensions
    {
        public static IEnumerable<SerializedProperty> GetSerializedProperties(this SerializedObject self, bool enterChildren)
        {
            Assert.IsNotNull(self);

            using var property = self.GetIterator();

            while (property.Next(enterChildren))
            {
                yield return property;
            }
        }
    }
}
