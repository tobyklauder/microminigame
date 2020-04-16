﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tobyplayercontroller : MonoBehaviour
{
    [SerializeField, Tooltip("Speed in which the tank can move from side to side")]
    float speed = 0.30f;
    [SerializeField, Tooltip("Number of times player can die before loosing")]
    public int lives = 3;
    [SerializeField, Tooltip("Object the player can fire")]
    GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bulletone = Instantiate(projectile, this.transform.position, transform.rotation);
            // bulletone.transform.eulerAngles = Vector3.forward * 90;
            bulletone.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 20, 0);
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A) && transform.position.x > -5)
        {
            Vector3 position = this.transform.position;
            position.x -= speed;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.D) && transform.position.x < 5)
        {
            Vector3 position = this.transform.position;
            position.x += speed;
            this.transform.position = position;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "alienbullet")
        {
            lives--;
            speed -= 0.10f;
            if (lives == 0)
            {
                Destroy(this.gameObject);
                //change scene 
            }
            Destroy(collision.gameObject);
        }
    }
}