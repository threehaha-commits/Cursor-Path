using UnityEngine;

public class LossGame : MonoBehaviour
{
    private GameObject _cursor;
    
    private void Awake()
    {
        _cursor = GameObject.FindGameObjectWithTag("Player");
        var life = FindObjectOfType<Life>();
        life.AddActionInt(CheckCurrentLife);
        var ads = FindObjectOfType<YandexAds>();
        ads.AddAction(ResumeGame);
        gameObject.SetActive(false);
    }

    private void CheckCurrentLife(int value)
    {
        if (value == 0)
        {
            _cursor.SetActive(false);
            gameObject.SetActive(true);
        }
    }

    private void ResumeGame()
    {
        gameObject.SetActive(false);
        _cursor.SetActive(true);
    }
}