using System;
using UnityEngine;

public class ActivateCursor : MonoBehaviour
{
    private GameObject _clickOnMe;

    private void Start()
    {
        Cursor.visible = true;
        _clickOnMe = GameObject.Find("Click On Me");
    }

    private void OnMouseDown()
    {
        if(_clickOnMe.activeInHierarchy)
            _clickOnMe.SetActive(false);
        GetComponent<MoveCursor>().StartMove();
        Cursor.visible = false;
    }
}