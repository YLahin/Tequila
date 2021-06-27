using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.Assertions;

namespace Tequila.Extensions
{
    public static class UnityObjectExtensions
    {
        public static bool TryGetAssetGuid(this Object self, out string assetGuid)
        {
            Assert.IsNotNull(self);

            if (self.TryGetAssetPath(out var assetPath))
            {
                assetGuid = AssetDatabase.AssetPathToGUID(assetPath);

                return !string.IsNullOrWhiteSpace(assetGuid);
            }

            assetGuid = default;

            return false;
        }

        public static bool TryGetAssetPath(this Object self, out string assetPath)
        {
            Assert.IsNotNull(self);

            assetPath = AssetDatabase.GetAssetPath(self);

            return !string.IsNullOrWhiteSpace(assetPath);
        }

        public static bool IsPersistent(this Object self)
        {
            Assert.IsNotNull(self);

            return EditorUtility.IsPersistent(self);
        }

        public static bool IsPreviewSceneObject(this Object self)
        {
            Assert.IsNotNull(self);

            return EditorSceneManager.IsPreviewSceneObject(self);
        }

        public static void SetDirty(this Object self, bool dirty)
        {
            Assert.IsNotNull(self);

            if (dirty)
            {
                EditorUtility.SetDirty(self);
            }
            else
            {
                EditorUtility.ClearDirty(self);
            }
        }
    }
}
