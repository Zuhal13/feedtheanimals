﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowBound = -10.0f;
    
    //sahnenin dısına cıkan game objectleri yok etmek icin

   
    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
    }
}
