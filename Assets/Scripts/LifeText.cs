using System;
using TMPro;
using UnityEngine;

public class LifeText : MonoBehaviour
{
    private TMP_Text _text;

    private void Awake()
    {
        _text = GetComponent<TMP_Text>();
        var life = FindObjectOfType<Life>();
        life.AddActionInt(ChangeLifeText);
    }

    private void ChangeLifeText(int value)
    {
        _text.text = "Попытки: " + value;
    }
}