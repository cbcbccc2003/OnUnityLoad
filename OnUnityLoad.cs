using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

[InitializeOnLoad]
public class OnUnityLoad {
    static OnUnityLoad() {
        EditorApplication.playmodeStateChanged = () => {
            if ( EditorApplication.isPlayingOrWillChangePlaymode && !EditorApplication.isPlaying ) {
                Debug.Log("Auto-Saving scene before entering Play mode: " + EditorSceneManager.loadedSceneCount);

                EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo();
                EditorApplication.SaveAssets();
            }
        };
    }
}