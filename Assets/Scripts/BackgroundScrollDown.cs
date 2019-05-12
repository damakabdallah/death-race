using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScrollDown : MonoBehaviour
{
    public float scrollSpeed = -50f;
    Vector2 _startPos;

    void Start()
    {
        _startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float newPos = Mathf.Repeat(Time.time * scrollSpeed, 10);
        transform.position = _startPos + Vector2.up * newPos;
    }
}