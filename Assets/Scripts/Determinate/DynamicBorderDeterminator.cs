using System;
using System.Collections.Generic;
using UnityEngine;

public class DynamicBorderDeterminator : Determinator 
{
    private CursorColliders _cursorColliders;
    
    private void Start()
    {
        _cursorColliders = FindObjectOfType<CursorColliders>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (_cursorColliders.CursorInsideOtherCollider())
            return;
        
        _determinateAction?.Invoke();
        Cursor.visible = true;
    }
}