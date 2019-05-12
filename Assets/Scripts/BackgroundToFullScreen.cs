using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundToFullScreen : MonoBehaviour
{
    private float _ScreenWidth;
    private float _ScreenhHeight;
 
    private float _SpriteWidth;
    private float _SpriteHeight;
    public SpriteRenderer _sr;

    void Update()
    {
        Camera.main.orthographicSize *= _sr.sprite.bounds.size.x;

    }
}