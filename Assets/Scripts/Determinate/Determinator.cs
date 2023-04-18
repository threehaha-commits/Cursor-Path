using UnityEngine;
using UnityEngine.Events;

public abstract class Determinator : MonoBehaviour
{
    protected UnityAction _determinateAction;
    
    public void AddAction(UnityAction action)
    {
        _determinateAction += action;
    }
}