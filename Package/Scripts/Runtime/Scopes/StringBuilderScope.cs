using System;
using System.Text;
using static Tequila.Utilities.PoolUtility;

namespace Tequila.Scopes
{
    public readonly struct StringBuilderScope : IDisposable
    {
        private readonly StringBuilder _stringBuilder;

        private StringBuilderScope(StringBuilder stringBuilder)
        {
            _stringBuilder = stringBuilder;
        }

        public static StringBuilderScope Create(out StringBuilder stringBuilder)
        {
            stringBuilder = PullValue<StringBuilder>();

            return new StringBuilderScope(stringBuilder);
        }

        void IDisposable.Dispose()
        {
            _stringBuilder.Clear();

            PushValue(_stringBuilder);
        }
    }
}
