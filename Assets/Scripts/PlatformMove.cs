using System;
using System.Collections;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    [SerializeField] private float _moveTime;
    [SerializeField] private Vector2 _start;
    [SerializeField] private Vector2 _end;
    [SerializeField] private AnimationCurve _curveX;
    [SerializeField] private AnimationCurve _curveY;
    private int _directionIndex;
    
    private void Start()
    {
        _start.y = _start.y == 0 ? transform.localPosition.y : _start.y;
        _start.x = _start.x == 0 ? transform.localPosition.x : _start.x;
        _end.y = _end.y == 0 ? transform.localPosition.y : _end.y;
        _end.x = _end.x == 0 ? transform.localPosition.x : _end.x;
        DefineDirection(++_directionIndex);
    }

    private IEnumerator Move(Vector2 a, Vector2 b)
    {
        var startTime = Time.time;
        var currentTime = 0f;
        while (currentTime < 1f)
        {
            currentTime = Mathf.Clamp01((Time.time - startTime) / _moveTime);
            var lerp = Vector2.Lerp(a, b, currentTime);
            transform.localPosition = lerp;
            var x = lerp.x + _curveX.Evaluate(currentTime) - 1f;
            var y = lerp.y + _curveY.Evaluate(currentTime) - 1f;
            var z = transform.localPosition.z;
            transform.localPosition = new Vector3(x,y,z);
            yield return null;
        }

        DefineDirection(++_directionIndex);
    }

    private void DefineDirection(int index)
    {
        if (index % 2 != 0)
            StartCoroutine(Move(_start, _end));
        else
            StartCoroutine(Move(_end, _start));
    }
}