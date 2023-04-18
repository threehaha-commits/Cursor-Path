using UnityEngine;

public class MoveCursor : MonoBehaviour
{
    private bool _canMove;
    private Camera _camera;
    private Transform _transform;
    
    private void Start()
    {
        _transform = transform;
        _camera = Camera.main;
        var borders = FindObjectsOfType<Determinator>();
        foreach (var border in borders)
            border.AddAction(EndMove);
    }

    private void EndMove()
    {
        _canMove = false;
    }
    
    public void StartMove()
    {
        _canMove = true;
    }
    
    private void Update()
    {
        if (_canMove == false)
            return;

        var mousePos = _camera.ScreenToWorldPoint(Input.mousePosition);
        var x = mousePos.x;
        var y = mousePos.y;
        _transform.position = new Vector3(x,y, _transform.position.z);
    }
}