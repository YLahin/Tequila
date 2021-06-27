using UnityEngine;

namespace Tequila.Extensions
{
    public static class RectExtensions
    {
        public static Rect Expand(this Rect self, Rect rect)
        {
            var xMin = Mathf.Min(self.xMin, rect.xMin);
            var yMin = Mathf.Min(self.yMin, rect.yMin);
            var xMax = Mathf.Max(self.xMax, rect.xMax);
            var yMax = Mathf.Max(self.yMax, rect.yMax);

            return Rect.MinMaxRect(xMin, yMin, xMax, yMax);
        }

        public static Rect Insersection(this Rect self, Rect rect)
        {
            var xMin = Mathf.Max(self.xMin, rect.xMin);
            var yMin = Mathf.Max(self.yMin, rect.yMin);
            var xMax = Mathf.Min(self.xMax, rect.xMax);
            var yMax = Mathf.Min(self.yMax, rect.yMax);

            return Rect.MinMaxRect(xMin, yMin, xMax, yMax);
        }

        public static bool IsZero(this Rect self)
        {
            return self.width <= 0f || self.height <= 0f;
        }

        public static Rect WithPadding(this Rect rect, float padding)
        {
            rect.position += new Vector2(padding, padding);
            rect.size -= new Vector2(padding, padding) * 2f;

            return rect;
        }
    }
}
