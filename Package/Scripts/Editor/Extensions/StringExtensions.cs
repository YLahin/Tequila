using UnityEditor;
using UnityEngine.Assertions;

namespace Tequila.Extensions
{
    public static class StringExtensions
    {
        public static string NicifyVariableName(this string self)
        {
            Assert.IsNotNull(self);

            return ObjectNames.NicifyVariableName(self);
        }
    }
}
