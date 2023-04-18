using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    private void Awake()
    {
        var objs = FindObjectsOfType<MusicPlayer>();

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
}