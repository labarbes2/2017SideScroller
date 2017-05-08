﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveablePlatform : MonoBehaviour
{

    private float useSpeed;
    public float directionSpeed = 5.0f;
    float origY;
    public float distance = 4.0f;

    void Start()
    {
        origY = transform.position.y;
        useSpeed = -directionSpeed;
    }

    void Update()
    {
        if (origY - transform.position.y > distance)
        {
            useSpeed = directionSpeed; //flip direction
        }
        else if (origY - transform.position.y < -distance)
        {
            useSpeed = -directionSpeed; //flip direction
        }
        transform.Translate(0, useSpeed * Time.deltaTime, 0);
    }
}
    




