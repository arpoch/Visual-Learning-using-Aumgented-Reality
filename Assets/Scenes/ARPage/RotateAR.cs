﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAR : MonoBehaviour
{
    float speed = 25.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,10*Time.deltaTime,0);
    }
}
