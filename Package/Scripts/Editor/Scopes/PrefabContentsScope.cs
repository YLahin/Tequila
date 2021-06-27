using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.Assertions;

namespace Tequila.Scopes
{
    public readonly struct PrefabContentsScope : IDisposable
    {
        private readonly GameObject _contents;

        private PrefabContentsScope(GameObject contents)
        {
            _contents = contents;
        }

        public static PrefabContentsScope Create(string assetPath, out GameObject contents)
        {
            Assert.IsFalse(string.IsNullOrWhiteSpace(assetPath));

            contents = PrefabUtility.LoadPrefabContents(assetPath);

            return new PrefabContentsScope(contents);
        }

        void IDisposable.Dispose()
        {
            Assert.IsNotNull(_contents);

            PrefabUtility.UnloadPrefabContents(_contents);
        }
    }
}
