using UnityEngine;

public class StaticBorderDeterminator : Determinator
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        _determinateAction?.Invoke(); 
        Cursor.visible = true;
    }
}