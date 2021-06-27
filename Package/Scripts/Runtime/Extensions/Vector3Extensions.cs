using UnityEngine;

namespace Tequila.Extensions
{
    public static class Vector3Extensions
    {
        private static readonly Vector3 _cellSize = new Vector3(0.05f, 0.05f, 0.05f);

        public static Vector3 Snap(this Vector3 self)
        {
            return self.Snap(_cellSize);
        }

        private static Vector3 Snap(this Vector3 self, Vector3 cellSize)
        {
            var x = Mathf.Round(self.x / cellSize.x) * cellSize.x;
            var y = Mathf.Round(self.y / cellSize.y) * cellSize.y;
            var z = Mathf.Round(self.z / cellSize.z) * cellSize.z;

            return new Vector3(x, y, z);
        }
    }
}
