using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{
    [SerializeField] private GameObject _endGameWindow;
    
    private void Start()
    {
        var finish = FindObjectOfType<CursorFinishEnter>();
        finish.AddAction(Win);
    }

    private void Win()
    {
        var sceneCount = SceneManager.sceneCountInBuildSettings;
        var nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextSceneIndex < sceneCount)
            SceneManager.LoadScene(nextSceneIndex);
        else
        {
            _endGameWindow.SetActive(true);
            Time.timeScale = 0f;
        }

    }
}