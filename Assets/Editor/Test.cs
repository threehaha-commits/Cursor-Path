using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Editor
{
    public class Test
    {
        [MenuItem("EditorOnly/Restat &R")]
        public static void Restart()
        {
            var currentScene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentScene);
        }

        [MenuItem("EditorOnly/Show Cursor %SPACE")]
        public static void ShowCursor()
        {
            Cursor.visible = true;
        }
    }
}