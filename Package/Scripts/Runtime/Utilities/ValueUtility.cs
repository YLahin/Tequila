using System;
using Tequila.Extensions;
using UnityEngine.Assertions;

namespace Tequila.Utilities
{
    public static class ValueUtility
    {
        public static float GetProgress(int index, int lenght)
        {
            Assert.IsTrue(index >= 0 && index < lenght);

            return (index + 1) / (float) lenght;
        }

        public static bool TrySetValue(ref float sourceValue, float targetValue)
        {
            if (sourceValue.Approximately(targetValue))
            {
                return false;
            }

            sourceValue = targetValue;

            return true;
        }

        public static bool TrySetValue<T>(ref T sourceValue, T targetValue)
            where T : IEquatable<T>
        {
            if (sourceValue.Equals(targetValue))
            {
                return false;
            }

            sourceValue = targetValue;

            return true;
        }
    }
}
