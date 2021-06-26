using System;

namespace Tequila.Extensions
{
    public static class DateTimeExtensions
    {
        public static long ToUnixTimeSeconds(this DateTime self)
        {
            return new DateTimeOffset(self)
                .ToUnixTimeSeconds();
        }
    }
}
