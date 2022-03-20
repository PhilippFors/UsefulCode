using UnityEngine;
using UsefulCode.SOArchitecture.Attributes;

namespace UsefulCode.SOArchitecture.Utility
{
    [System.Serializable]
    [MultiLine]
    public sealed class SceneInfo : ISerializationCallbackReceiver
    {
        /// <summary>
        /// Returns the fully-qualified name of the scene.
        /// </summary>
        public string SceneName
        {
            get { return _sceneName; }
        }

        public string ScenePath
        {
            get { return _scenePath; }
        }

        /// <summary>
        /// Returns the index of the scene in the build settings; if not present, -1 will be returned instead.
        /// </summary>
        public int SceneIndex
        {
            get { return _sceneIndex; }
            internal set { _sceneIndex = value; }
        }

        /// <summary>
        /// Returns true if the scene is present in the build settings, otherwise false.
        /// </summary>
        public bool IsSceneInBuildSettings
        {
            get { return _sceneIndex != -1; }
        }

        /// <summary>
        /// Returns true if the scene is enabled in the build settings, otherwise false.
        /// </summary>
        public bool IsSceneEnabled
        {
            get { return _isSceneEnabled; }
            internal set { _isSceneEnabled = value; }
        }

        #if UNITY_EDITOR
        internal UnityEditor.SceneAsset Scene
        {
            get { return UnityEditor.AssetDatabase.LoadAssetAtPath<UnityEditor.SceneAsset>(_scenePath); }
        }
        #endif

        #pragma warning disable 0649

        [SerializeField]
        private string _sceneName;

        [SerializeField]
        private string _scenePath;

        [SerializeField]
        private int _sceneIndex;

        [SerializeField]
        private bool _isSceneEnabled;

        #pragma warning restore 0649

        public SceneInfo()
        {
            _sceneIndex = -1;
        }

        #region ISerializationCallbackReceiver

        public void OnBeforeSerialize()
        {
            #if UNITY_EDITOR
            if (Scene != null)
            {
                var sceneAssetPath = UnityEditor.AssetDatabase.GetAssetPath(Scene);
                var sceneAssetGUID = UnityEditor.AssetDatabase.AssetPathToGUID(sceneAssetPath);
                var scenes = UnityEditor.EditorBuildSettings.scenes;

                SceneIndex = -1;
                for (var i = 0; i < scenes.Length; i++)
                {
                    if (scenes[i].guid.ToString() == sceneAssetGUID)
                    {
                        SceneIndex = i;
                        IsSceneEnabled = scenes[i].enabled;
                        break;
                    }
                }
            }
            #endif
        }

        public void OnAfterDeserialize(){}

        #endregion
    }
}