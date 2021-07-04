using System.Collections.Generic;
using UnityEditor;
using UnityEngine.Assertions;

namespace Tequila.Extensions
{
    public static class SerializedObjectExtensions
    {
        public static IEnumerable<SerializedProperty> GetSerializedProperties(this SerializedObject self, bool enterChildren, bool onlyVisible)
        {
            Assert.IsNotNull(self);

            using var iterator = self.GetIterator();

            if (onlyVisible)
            {
                while (iterator.NextVisible(enterChildren))
                {
                    yield return iterator;
                }
            }
            else
            {
                while (iterator.Next(enterChildren))
                {
                    yield return iterator;
                }
            }
        }
    }
}
