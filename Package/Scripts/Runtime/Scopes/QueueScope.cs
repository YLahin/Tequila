using System;
using System.Collections.Generic;
using static Tequila.Utilities.PoolUtility;

namespace Tequila.Scopes
{
    public readonly struct QueueScope<T> : IDisposable
    {
        private readonly Queue<T> _queue;

        private QueueScope(Queue<T> queue)
        {
            _queue = queue;
        }

        public static QueueScope<T> Create(out Queue<T> queue)
        {
            queue = PullValue<Queue<T>>();

            return new QueueScope<T>(queue);
        }

        void IDisposable.Dispose()
        {
            _queue.Clear();

            PushValue(_queue);
        }
    }
}
