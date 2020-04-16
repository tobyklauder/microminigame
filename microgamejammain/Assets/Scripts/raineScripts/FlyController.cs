using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyController : MonoBehaviour
{
    private Rigidbody2D rb;
    public static bool canMove = true;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.isKinematic = true;

        rb.velocity = new Vector2(5f, 5f);
    }
    void Update()
    {
        if(canMove)
        {
            rb.isKinematic = false;
        }
        else if(!canMove)
        {
            rb.isKinematic = true;
        }
    }

}

