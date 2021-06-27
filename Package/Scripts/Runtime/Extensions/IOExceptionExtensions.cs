using System.IO;
using UnityEngine.Assertions;

namespace Tequila.Extensions
{
    public static class IOExceptionExtensions
    {
        public static bool IsDiskFull(this IOException self)
        {
            Assert.IsNotNull(self);

            var errorCode = self.HResult & 0x0000FFFF;

            return errorCode switch
            {
                39 => true, // ERROR_HANDLE_DISK_FULL
                112 => true, // ERROR_DISK_FULL
                _ => false
            };
        }
    }
}
