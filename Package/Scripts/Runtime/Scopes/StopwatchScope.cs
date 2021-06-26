using System;
using System.Diagnostics;
using static Tequila.Utilities.PoolUtility;

namespace Tequila.Scopes
{
    public readonly struct StopwatchScope : IDisposable
    {
        private readonly Stopwatch _stopwatch;

        private StopwatchScope(Stopwatch stopwatch)
        {
            _stopwatch = stopwatch;
        }

        public static StopwatchScope Create(out Stopwatch stopwatch)
        {
            stopwatch = PullValue<Stopwatch>();

            return new StopwatchScope(stopwatch);
        }

        void IDisposable.Dispose()
        {
            _stopwatch.Reset();

            PushValue(_stopwatch);
        }
    }
}
