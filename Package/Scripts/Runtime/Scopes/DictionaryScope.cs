using System;
using System.Collections.Generic;
using static Tequila.Utilities.PoolUtility;

namespace Tequila.Scopes
{
    public readonly struct DictionaryScope<TKey, TValue> : IDisposable
    {
        private readonly Dictionary<TKey, TValue> _dictionary;

        private DictionaryScope(Dictionary<TKey, TValue> dictionary)
        {
            _dictionary = dictionary;
        }

        public static DictionaryScope<TKey, TValue> Create(out Dictionary<TKey, TValue> dictionary)
        {
            dictionary = PullValue<Dictionary<TKey, TValue>>();

            return new DictionaryScope<TKey, TValue>(dictionary);
        }

        void IDisposable.Dispose()
        {
            _dictionary.Clear();

            PushValue(_dictionary);
        }
    }
}
