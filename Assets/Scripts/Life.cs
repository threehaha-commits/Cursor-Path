using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Life : MonoBehaviour
{
    private static int _currentLife = 5;
    private static int _maxLife = 5;
    private static Life _instace = null;
    public static Life Instance
    {
        get
        {
            if (_instace == null)
                _instace = FindObjectOfType<Life>();
            return _instace;
        }
    }

    private UnityAction<int> _lifeAction;

    public void ResetLife()
    {
        _currentLife = _maxLife;
    }
    
    public void AddActionInt(UnityAction<int> action)
    {
        _lifeAction += action;
    }
    
    public int GetLifeCount()
    {
        return _currentLife;
    }

    private void Start()
    {
        AddDeterminateAction();
        AddAdsAction();
        UpdateLifeText();
    }

    private void UpdateLifeText()
    {
        _lifeAction?.Invoke(_currentLife);
    }

    private void AddAdsAction()
    {
        var ads = FindObjectOfType<YandexAds>();
        ads.AddAction(ResumeGame);
    }

    private void AddDeterminateAction()
    {
        var borders = FindObjectsOfType<Determinator>();
        foreach (var border in borders)
            border.AddAction(CursorOutAction);
    }

    private void CursorOutAction()
    {
        _currentLife--;
        _lifeAction?.Invoke(_currentLife);
    }

    private void ResumeGame()
    {
        ResetLife();
        _lifeAction?.Invoke(_currentLife);
    }
}