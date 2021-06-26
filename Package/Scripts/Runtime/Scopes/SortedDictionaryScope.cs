using System;
using System.Collections.Generic;
using static Tequila.Utilities.PoolUtility;

namespace Tequila.Scopes
{
    public readonly struct SortedDictionaryScope<TKey, TValue> : IDisposable
    {
        private readonly SortedDictionary<TKey, TValue> _dictionary;

        private SortedDictionaryScope(SortedDictionary<TKey, TValue> dictionary)
        {
            _dictionary = dictionary;
        }

        public static SortedDictionaryScope<TKey, TValue> Create(out SortedDictionary<TKey, TValue> dictionary)
        {
            dictionary = PullValue<SortedDictionary<TKey, TValue>>();

            return new SortedDictionaryScope<TKey, TValue>(dictionary);
        }

        void IDisposable.Dispose()
        {
            _dictionary.Clear();

            PushValue(_dictionary);
        }
    }
}
