using NUnit.Framework;
using UnityEditor.Events;
using UnityEngine;
using UnityEngine.Events;

namespace Tequila.Extensions
{
    public static class UnityEventBaseExtensions
    {
        public static void AddPersistentListener(this UnityEventBase self)
        {
            Assert.IsNotNull(self);

            UnityEventTools.AddPersistentListener(self);
        }

        public static void AddPersistentListener(this UnityEventBase self, UnityAction unityAction)
        {
            Assert.IsNotNull(self);
            Assert.IsNotNull(unityAction);

            UnityEventTools.AddVoidPersistentListener(self, unityAction);
        }

        public static void AddPersistentListener(this UnityEventBase self, UnityAction<bool> unityAction, bool argument)
        {
            Assert.IsNotNull(self);
            Assert.IsNotNull(unityAction);

            UnityEventTools.AddBoolPersistentListener(self, unityAction, argument);
        }

        public static void AddPersistentListener(this UnityEventBase self, UnityAction<float> unityAction, float argument)
        {
            Assert.IsNotNull(self);
            Assert.IsNotNull(unityAction);

            UnityEventTools.AddFloatPersistentListener(self, unityAction, argument);
        }

        public static void AddPersistentListener(this UnityEventBase self, UnityAction<int> unityAction, int argument)
        {
            Assert.IsNotNull(self);
            Assert.IsNotNull(unityAction);

            UnityEventTools.AddIntPersistentListener(self, unityAction, argument);
        }

        public static void AddPersistentListener<T>(this UnityEventBase self, UnityAction<T> unityAction, T argument)
            where T : Object
        {
            Assert.IsNotNull(self);
            Assert.IsNotNull(unityAction);

            UnityEventTools.AddObjectPersistentListener(self, unityAction, argument);
        }

        public static void AddPersistentListener(this UnityEventBase self, UnityAction<string> unityAction, string argument)
        {
            Assert.IsNotNull(self);
            Assert.IsNotNull(unityAction);

            UnityEventTools.AddStringPersistentListener(self, unityAction, argument);
        }

        public static void RegisterPersistentListener(this UnityEventBase self, int index, UnityAction unityAction)
        {
            Assert.IsNotNull(self);
            Assert.GreaterOrEqual(index, 0);
            Assert.IsNotNull(unityAction);

            UnityEventTools.RegisterVoidPersistentListener(self, index, unityAction);
        }

        public static void RegisterPersistentListener(this UnityEventBase self, int index, UnityAction<bool> unityAction, bool argument)
        {
            Assert.IsNotNull(self);
            Assert.GreaterOrEqual(index, 0);
            Assert.IsNotNull(unityAction);

            UnityEventTools.RegisterBoolPersistentListener(self, index, unityAction, argument);
        }

        public static void RegisterPersistentListener<T>(this UnityEventBase self, int index, UnityAction<T> unityAction, T argument)
            where T : Object
        {
            Assert.IsNotNull(self);
            Assert.GreaterOrEqual(index, 0);
            Assert.IsNotNull(unityAction);

            UnityEventTools.RegisterObjectPersistentListener(self, index, unityAction, argument);
        }

        public static void RegisterPersistentListener(this UnityEventBase self, int index, UnityAction<int> unityAction, int argument)
        {
            Assert.IsNotNull(self);
            Assert.GreaterOrEqual(index, 0);
            Assert.IsNotNull(unityAction);

            UnityEventTools.RegisterIntPersistentListener(self, index, unityAction, argument);
        }

        public static void RegisterPersistentListener(this UnityEventBase self, int index, UnityAction<string> unityAction, string argument)
        {
            Assert.IsNotNull(self);
            Assert.GreaterOrEqual(index, 0);
            Assert.IsNotNull(unityAction);

            UnityEventTools.RegisterStringPersistentListener(self, index, unityAction, argument);
        }

        public static void RegisterPersistentListener(this UnityEventBase self, int index, UnityAction<float> unityAction, float argument)
        {
            Assert.IsNotNull(self);
            Assert.GreaterOrEqual(index, 0);
            Assert.IsNotNull(unityAction);

            UnityEventTools.RegisterFloatPersistentListener(self, index, unityAction, argument);
        }

        public static void RemovePersistentListener<T0>(this UnityEventBase self, UnityAction<T0> unityAction)
        {
            Assert.IsNotNull(self);
            Assert.IsNotNull(unityAction);

            UnityEventTools.RemovePersistentListener(self, unityAction);
        }

        public static void RemovePersistentListener(this UnityEventBase self, int index)
        {
            Assert.IsNotNull(self);
            Assert.GreaterOrEqual(index, 0);

            UnityEventTools.RemovePersistentListener(self, index);
        }

        public static void RemovePersistentListener(this UnityEventBase self, UnityAction unityAction)
        {
            Assert.IsNotNull(self);
            Assert.IsNotNull(unityAction);

            UnityEventTools.RemovePersistentListener(self, unityAction);
        }

        public static void RemovePersistentListener<T0, T1>(this UnityEventBase self, UnityAction<T0, T1> unityAction)
        {
            Assert.IsNotNull(self);
            Assert.IsNotNull(unityAction);

            UnityEventTools.RemovePersistentListener(self, unityAction);
        }

        public static void RemovePersistentListener<T0, T1, T2>(this UnityEventBase self, UnityAction<T0, T1, T2> unityAction)
        {
            Assert.IsNotNull(self);
            Assert.IsNotNull(unityAction);

            UnityEventTools.RemovePersistentListener(self, unityAction);
        }

        public static void RemovePersistentListener<T0, T1, T2, T3>(this UnityEventBase self, UnityAction<T0, T1, T2, T3> unityAction)
        {
            Assert.IsNotNull(self);
            Assert.IsNotNull(unityAction);

            UnityEventTools.RemovePersistentListener(self, unityAction);
        }

        public static void RemovePersistentListeners(this UnityEventBase self)
        {
            Assert.IsNotNull(self);

            var count = self.GetPersistentEventCount();

            for (var i = 0; i < count; ++i)
            {
                UnityEventTools.RemovePersistentListener(self, i);
            }
        }

        public static void UnregisterPersistentListener(this UnityEventBase self, int index)
        {
            Assert.IsNotNull(self);
            Assert.GreaterOrEqual(index, 0);

            UnityEventTools.UnregisterPersistentListener(self, index);
        }

        public static void UnregisterPersistentListeners(this UnityEventBase self)
        {
            Assert.IsNotNull(self);

            var count = self.GetPersistentEventCount();

            for (var i = 0; i < count; ++i)
            {
                UnityEventTools.UnregisterPersistentListener(self, i);
            }
        }
    }
}
