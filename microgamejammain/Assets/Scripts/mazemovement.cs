/*
 * mazemovement.cs
 * By: Esther Strathy
 * 4/14/2020
 * Description: allows for character movement in the maze minigame 
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mazemovement : MonoBehaviour
{
    Rigidbody2D myrb;
    [SerializeField] float acceleration = 1.2f;
    [SerializeField] float deceleration = .5f;
    [SerializeField] float speed = 5f;

    Vector2 velocity;
    // Start is called before the first frame update
    void Start()
    {
        myrb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move()
    {
        //horizontal movement
        if (Input.GetAxis("Horizontal") != 0)
        {
                velocity.x = Mathf.MoveTowards(velocity.x, speed * Input.GetAxis("Horizontal"), acceleration * Time.fixedDeltaTime);
                myrb.velocity = new Vector2(velocity.x, velocity.y);
        }
        else
        {

            velocity.x = Mathf.MoveTowards(velocity.x, speed * Input.GetAxis("Horizontal"), deceleration * Time.fixedDeltaTime);
            myrb.velocity = new Vector2(velocity.x, velocity.y);
        }
        
        //vertical movment
        if (Input.GetAxis("Vertical") != 0)
        {
            velocity.y = Mathf.MoveTowards(velocity.y, speed * Input.GetAxis("Vertical"), acceleration * Time.fixedDeltaTime);
            myrb.velocity = new Vector2(velocity.x, velocity.y);
        }
        else
        {

            velocity.y = Mathf.MoveTowards(velocity.y, speed * Input.GetAxis("Vertical"), deceleration * Time.fixedDeltaTime);
            myrb.velocity = new Vector2(velocity.x, velocity.y);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
