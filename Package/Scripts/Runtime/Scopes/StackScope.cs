using System;
using System.Collections.Generic;
using UnityEngine.Assertions;
using static Tequila.Utilities.PoolUtility;

namespace Tequila.Scopes
{
    public readonly struct StackScope<T> : IDisposable
    {
        private readonly Stack<T> _stack;

        private StackScope(Stack<T> stack)
        {
            _stack = stack;
        }

        public static StackScope<T> Create(out Stack<T> stack)
        {
            stack = PullValue<Stack<T>>();

            return new StackScope<T>(stack);
        }

        void IDisposable.Dispose()
        {
            Assert.IsNotNull(_stack);

            _stack.Clear();

            PushValue(_stack);
        }
    }
}
