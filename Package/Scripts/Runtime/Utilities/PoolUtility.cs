namespace Tequila.Utilities
{
    public static partial class PoolUtility
    {
        public static void PushValue<T>(T value)
            where T : class, new()
        {
            Buffer<T>.PushValue(value);
        }

        public static T PullValue<T>()
            where T : class, new()
        {
            return Buffer<T>.PullValue();
        }
    }
}
