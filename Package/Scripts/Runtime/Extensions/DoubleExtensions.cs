using System;

namespace Tequila.Extensions
{
    public static class DoubleExtensions
    {
        public static double Ceiling(this double self)
        {
            return Math.Ceiling(self);
        }

        public static double Floor(this double self)
        {
            return Math.Floor(self);
        }

        public static double Round(this double self)
        {
            return Math.Round(self);
        }
    }
}
