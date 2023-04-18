using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class CursorFinishEnter : MonoBehaviour
{
    private UnityAction _finishAction;
    
    public void AddAction(UnityAction action)
    {
        _finishAction += action;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        _finishAction?.Invoke();
    }
}