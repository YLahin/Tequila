using NUnit.Framework;
using UnityEditor.Events;
using UnityEngine.Events;

namespace Tequila.Extensions
{
    public static class UnityEventExtensions
    {
        public static void AddPersistentListener(this UnityEvent self, UnityAction unityAction)
        {
            Assert.IsNotNull(self);
            Assert.IsNotNull(unityAction);

            UnityEventTools.AddPersistentListener(self, unityAction);
        }

        public static void AddPersistentListener<T0>(this UnityEvent<T0> self, UnityAction<T0> unityAction)
        {
            Assert.IsNotNull(self);
            Assert.IsNotNull(unityAction);

            UnityEventTools.AddPersistentListener(self, unityAction);
        }

        public static void AddPersistentListener<T0, T1>(this UnityEvent<T0, T1> self, UnityAction<T0, T1> unityAction)
        {
            Assert.IsNotNull(self);
            Assert.IsNotNull(unityAction);

            UnityEventTools.AddPersistentListener(self, unityAction);
        }

        public static void AddPersistentListener<T0, T1, T2>(this UnityEvent<T0, T1, T2> self, UnityAction<T0, T1, T2> unityAction)
        {
            Assert.IsNotNull(self);
            Assert.IsNotNull(unityAction);

            UnityEventTools.AddPersistentListener(self, unityAction);
        }

        public static void AddPersistentListener<T0, T1, T2, T3>(this UnityEvent<T0, T1, T2, T3> self, UnityAction<T0, T1, T2, T3> unityAction)
        {
            Assert.IsNotNull(self);
            Assert.IsNotNull(unityAction);

            UnityEventTools.AddPersistentListener(self, unityAction);
        }

        public static void RegisterPersistentListener<T0, T1, T2, T3>(this UnityEvent<T0, T1, T2, T3> self, int index, UnityAction<T0, T1, T2, T3> unityAction)
        {
            Assert.IsNotNull(self);
            Assert.GreaterOrEqual(index, 0);
            Assert.IsNotNull(unityAction);

            UnityEventTools.RegisterPersistentListener(self, index, unityAction);
        }

        public static void RegisterPersistentListener<T0, T1, T2>(this UnityEvent<T0, T1, T2> self, int index, UnityAction<T0, T1, T2> unityAction)
        {
            Assert.IsNotNull(self);
            Assert.GreaterOrEqual(index, 0);
            Assert.IsNotNull(unityAction);

            UnityEventTools.RegisterPersistentListener(self, index, unityAction);
        }

        public static void RegisterPersistentListener<T0, T1>(this UnityEvent<T0, T1> self, int index, UnityAction<T0, T1> unityAction)
        {
            Assert.IsNotNull(self);
            Assert.GreaterOrEqual(index, 0);
            Assert.IsNotNull(unityAction);

            UnityEventTools.RegisterPersistentListener(self, index, unityAction);
        }

        public static void RegisterPersistentListener<T0>(this UnityEvent<T0> self, int index, UnityAction<T0> unityAction)
        {
            Assert.IsNotNull(self);
            Assert.GreaterOrEqual(index, 0);
            Assert.IsNotNull(unityAction);

            UnityEventTools.RegisterPersistentListener(self, index, unityAction);
        }

        public static void RegisterPersistentListener(this UnityEvent self, int index, UnityAction unityAction)
        {
            Assert.IsNotNull(self);
            Assert.GreaterOrEqual(index, 0);
            Assert.IsNotNull(unityAction);

            UnityEventTools.RegisterPersistentListener(self, index, unityAction);
        }
    }
}
