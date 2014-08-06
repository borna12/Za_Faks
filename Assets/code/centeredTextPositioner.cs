﻿using System;
using UnityEngine;
using System.Collections;

public class CenteredTextPositioner : IFloatingTextPositioner {
    private readonly float _speed;
    private float _textPosition;

    public CenteredTextPositioner(float speed)
    {
        _speed = speed;
    }

public bool GetPosition(ref UnityEngine.Vector2 position, UnityEngine.GUIContent content, UnityEngine.Vector2 size)
{
    _textPosition += Time.deltaTime*_speed;
    if (_textPosition > 1)
        return false;
    
    position = new Vector2(Screen.width /2f - size.x /2f, Mathf.Lerp(Screen.height/2f + size.y, 0, _textPosition));
    return true;
}
}
