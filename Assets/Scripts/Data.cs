using UnityEngine;
using UnityEngine.SceneManagement;

public static class Data
{
    public static void Save()
    {
        var sceneIndex = SceneManager.GetActiveScene().buildIndex;
        var lifeCount = Life.Instance.GetLifeCount();
        PlayerPrefs.SetInt("Life", lifeCount);
        PlayerPrefs.SetInt("Scene", sceneIndex);
    }
}