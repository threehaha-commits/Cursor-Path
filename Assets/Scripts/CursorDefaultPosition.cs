using System;
using UnityEngine;

public class CursorDefaultPosition : MonoBehaviour
{
    private Vector3 _defaultPosition;
    
    private void Start()
    {
        _defaultPosition = transform.position;
        var borders = FindObjectsOfType<Determinator>();
        foreach (var border in borders)
            border.AddAction(ResetPosition);
    }

    private void ResetPosition()
    {
        transform.position = _defaultPosition;
    }
}