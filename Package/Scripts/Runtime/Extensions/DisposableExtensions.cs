using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine.Assertions;

namespace Tequila.Extensions
{
    [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
    public static class DisposableExtensions
    {
        public static void Dispose(this IEnumerable<IDisposable> self)
        {
            Assert.IsNotNull(self);

            foreach (var disposable in self)
            {
                disposable.Dispose();
            }
        }
    }
}
