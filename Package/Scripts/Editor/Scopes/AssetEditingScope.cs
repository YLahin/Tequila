using System;
using UnityEditor;
using UnityEngine.Assertions;

namespace Tequila.Scopes
{
    public readonly struct AssetEditingScope : IDisposable
    {
        private readonly bool _valid;

        private AssetEditingScope(bool valid)
        {
            _valid = valid;
        }

        public static AssetEditingScope Create()
        {
            AssetDatabase.StartAssetEditing();

            return new AssetEditingScope(true);
        }

        void IDisposable.Dispose()
        {
            Assert.IsTrue(_valid);
            AssetDatabase.StopAssetEditing();
        }
    }
}
