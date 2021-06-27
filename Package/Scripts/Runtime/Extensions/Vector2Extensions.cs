using UnityEngine;

namespace Tequila.Extensions
{
    public static class Vector2Extensions
    {
        private static readonly Vector2 _cellSize = new Vector3(0.05f, 0.05f);

        public static Vector2 Snap(this Vector2 self)
        {
            return self.Snap(_cellSize);
        }

        private static Vector2 Snap(this Vector2 self, Vector2 cellSize)
        {
            var x = Mathf.Round(self.x / cellSize.x) * cellSize.x;
            var y = Mathf.Round(self.y / cellSize.y) * cellSize.y;

            return new Vector2(x, y);
        }
    }
}
