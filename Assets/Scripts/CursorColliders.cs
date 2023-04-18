using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CursorColliders : MonoBehaviour
{
    [SerializeField] private List<Collider2D> _colliders = new();

    public bool CursorInsideOtherCollider()
    {
        return _colliders.Count > 0;
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Border"))
            return;
        AddCollider(other);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag.Equals("Border"))
            return;
        RemoveCollider(other);
    }

    private void AddCollider(Collider2D col)
    {
        _colliders.Add(col);
    }

    private void RemoveCollider(Collider2D col)
    {
        _colliders.Remove(col);
    }
}