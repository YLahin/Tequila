using UnityEngine;

namespace Tequila.Extensions
{
    public static class BoundsExtensions
    {
        public static bool IsZero(this Bounds self)
        {
            var size = self.size;

            return size.x.Approximately(0f) && size.y.Approximately(0f) && size.z.Approximately(0f);
        }

        public static Rect ToRect(this Bounds self)
        {
            return new Rect(self.min, self.size);
        }
    }
}
