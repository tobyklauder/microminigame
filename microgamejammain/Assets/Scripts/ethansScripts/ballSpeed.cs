﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballSpeed : MonoBehaviour
{
    public Rigidbody2D rb;

    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
