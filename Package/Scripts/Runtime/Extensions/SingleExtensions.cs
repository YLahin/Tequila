using UnityEngine;

namespace Tequila.Extensions
{
    public static class SingleExtensions
    {
        public static bool Approximately(this float self, float value)
        {
            return Mathf.Approximately(self, value);
        }

        public static float Ceiling(this float self)
        {
            return Mathf.Ceil(self);
        }

        public static float Floor(this float self)
        {
            return Mathf.Floor(self);
        }

        public static float Round(this float self)
        {
            return Mathf.Round(self);
        }

        public static bool IsNaN(this float self)
        {
            return float.IsNaN(self);
        }

        public static bool IsInfinity(this float self)
        {
            return float.IsInfinity(self);
        }

        public static bool IsNegativeInfinity(this float self)
        {
            return float.IsNegativeInfinity(self);
        }

        public static bool IsNormalized(this float self)
        {
            return self >= 0 && self <= 1f;
        }

        public static bool IsPositiveInfinity(this float self)
        {
            return float.IsPositiveInfinity(self);
        }
    }
}
