using UnityEditor;
using UnityEngine;
using UsefulCode.SOArchitecture.Utility;

namespace UsefulCode.SOArchitecture.Editor.Property_Drawers
{
    [CustomPropertyDrawer(typeof(SceneInfo))]
    public class SceneInfoPropertyDrawer : PropertyDrawer
    {
        private const string SCENE_PREVIEW_TITLE = "Preview (Read-Only)";
        private const string SCENE_NAME_PROPERTY = "_sceneName";
        private const string SCENE_PATH_PROPERTY = "_scenePath";
        private const string SCENE_INDEX_PROPERTY = "_sceneIndex";
        private const string SCENE_ENABLED_PROPERTY = "_isSceneEnabled";
        private const int FIELD_COUNT = 6;

        public override void OnGUI(Rect propertyRect, SerializedProperty property, GUIContent label)
        {
            var sceneNameProperty = property.FindPropertyRelative(SCENE_NAME_PROPERTY);
            var scenePathProperty = property.FindPropertyRelative(SCENE_PATH_PROPERTY);
            var sceneIndexProperty = property.FindPropertyRelative(SCENE_INDEX_PROPERTY);
            var enabledProperty = property.FindPropertyRelative(SCENE_ENABLED_PROPERTY);

            EditorGUI.BeginProperty(propertyRect, new GUIContent(property.displayName), property);
            EditorGUI.BeginChangeCheck();

            // Draw Object Selector for SceneAssets
            var sceneAssetRect = new Rect
            {
                position = propertyRect.position,
                size = new Vector2(propertyRect.width, EditorGUIUtility.singleLineHeight)
            };

            var oldSceneAsset = AssetDatabase.LoadAssetAtPath<SceneAsset>(sceneNameProperty.stringValue);
            var sceneAsset = EditorGUI.ObjectField(sceneAssetRect, oldSceneAsset, typeof(SceneAsset), false);
            var sceneAssetPath = AssetDatabase.GetAssetPath(sceneAsset);
            
            var split1 = sceneAssetPath.Split('/');
            var split2 = split1[split1.Length - 1].Split('.');
            var sceneName = split2[0];
            
            if (scenePathProperty.stringValue != sceneAssetPath)
            {
                scenePathProperty.stringValue = sceneAssetPath;
            }

            if (sceneNameProperty.stringValue != sceneName) {
                sceneNameProperty.stringValue = sceneName;
            }

            if (string.IsNullOrEmpty(sceneNameProperty.stringValue))
            {
                sceneIndexProperty.intValue = -1;
                enabledProperty.boolValue = false;
            }

            // Draw preview fields for scene information.
            var titleLabelRect = sceneAssetRect;
            titleLabelRect.y += EditorGUIUtility.singleLineHeight;

            EditorGUI.LabelField(titleLabelRect, SCENE_PREVIEW_TITLE);
            EditorGUI.BeginDisabledGroup(true);
            var nameRect = titleLabelRect;
            nameRect.y += EditorGUIUtility.singleLineHeight;
            
            var pathRect = nameRect;
            pathRect.y += EditorGUIUtility.singleLineHeight;

            var indexRect = pathRect;
            indexRect.y += EditorGUIUtility.singleLineHeight;

            var enabledRect = indexRect;
            enabledRect.y += EditorGUIUtility.singleLineHeight;

            EditorGUI.PropertyField(nameRect, sceneNameProperty);
            EditorGUI.PropertyField(pathRect, sceneNameProperty);
            EditorGUI.PropertyField(indexRect, sceneIndexProperty);
            EditorGUI.PropertyField(enabledRect, enabledProperty);
            EditorGUI.EndDisabledGroup();
            if (EditorGUI.EndChangeCheck())
            {
                property.serializedObject.ApplyModifiedProperties();
            }
            EditorGUI.EndProperty();
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUIUtility.singleLineHeight * FIELD_COUNT + ((FIELD_COUNT - 1) * EditorGUIUtility.standardVerticalSpacing);
        }
    }
}