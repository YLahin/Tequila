using System;
using System.Collections.Generic;
using static Tequila.Utilities.PoolUtility;

namespace Tequila.Scopes
{
    public readonly struct HashSetScope<T> : IDisposable
    {
        private readonly HashSet<T> _hashSet;

        private HashSetScope(HashSet<T> hashSet)
        {
            _hashSet = hashSet;
        }

        public static HashSetScope<T> Create(out HashSet<T> hashSet)
        {
            hashSet = PullValue<HashSet<T>>();

            return new HashSetScope<T>(hashSet);
        }

        void IDisposable.Dispose()
        {
            _hashSet.Clear();

            PushValue(_hashSet);
        }
    }
}
