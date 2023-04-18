using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

public class YandexAds : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void ShowFullscreen();

    [DllImport("__Internal")]
    private static extern void ShowRewarded();
    
    private AudioSource[] _audio;
    private UnityAction _resumeAction;
    
    private void Start() 
    {
        _audio = FindObjectsOfType<AudioSource>();
    }

    public void AddAction(UnityAction action)
    {
        _resumeAction += action;
    }
    
    public void Show()
    {
        ShowRewarded();
    }

    public void ResumeGame()
    {
        _resumeAction?.Invoke();
    }
    
    public void WebAdShow()
    {
        foreach (var a in _audio) 
            a.mute = true;
    }

    public void WebAdClose()
    {
        foreach (var a in _audio) 
            a.mute = false;
    }
}