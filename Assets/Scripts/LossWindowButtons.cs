using UnityEngine;
using UnityEngine.SceneManagement;

public class LossWindowButtons : MonoBehaviour
{
    public void Restart()
    {
        Life.Instance.ResetLife();
        SceneManager.LoadScene(0);
    }

    public void Resume()
    {
        var ads = FindObjectOfType<YandexAds>(true);
        ads.Show();
    }
}