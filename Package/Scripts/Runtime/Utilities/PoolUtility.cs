namespace Tequila.Utilities
{
    public static partial class PoolUtility
    {
        public static void PushValue<T>(T value)
            where T : class, new()
        {
            StaticPool<T>.PushValue(value);
        }

        public static T PullValue<T>()
            where T : class, new()
        {
            return StaticPool<T>.PullValue();
        }
    }
}
