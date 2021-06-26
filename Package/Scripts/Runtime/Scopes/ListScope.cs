using System;
using System.Collections.Generic;
using static Tequila.Utilities.PoolUtility;

namespace Tequila.Scopes
{
    public readonly struct ListScope<T> : IDisposable
    {
        private readonly List<T> _list;

        private ListScope(List<T> list)
        {
            _list = list;
        }

        public static ListScope<T> Create(out List<T> list)
        {
            list = PullValue<List<T>>();

            return new ListScope<T>(list);
        }

        void IDisposable.Dispose()
        {
            _list.Clear();

            PushValue(_list);
        }
    }
}
