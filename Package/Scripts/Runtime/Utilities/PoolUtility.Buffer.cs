using System.Collections.Generic;
using UnityEngine.Assertions;

namespace Tequila.Utilities
{
    public static partial class PoolUtility
    {
        private static class Buffer<T>
            where T : class, new()
        {
            private static readonly Stack<T> _values = new Stack<T>();

            public static void PushValue(T value)
            {
                Assert.IsFalse(_values.Contains(value));

                _values.Push(value);
            }

            public static T PullValue()
            {
                return _values.Count > 0
                    ? _values.Pop()
                    : new T();
            }
        }
    }
}
