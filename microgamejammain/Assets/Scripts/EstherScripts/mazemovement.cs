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
    private BoxCollider2D boxcollider;
    Animator myanim;
    SpriteRenderer spriterend;
    Vector2 velocity;
    // Start is called before the first frame update
    void Start()
    {
        myrb = GetComponent<Rigidbody2D>();
        myanim = GetComponent<Animator>();
        spriterend = GetComponent<SpriteRenderer>();
        boxcollider = GetComponent<BoxCollider2D>();
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
            //left right animations and sprite render flip
            //right
            if (Input.GetAxis("Horizontal") >= 0)
            {
                myanim.SetInteger("State", 2);
                spriterend.flipX = false;
            }
            //left
            if (Input.GetAxis("Horizontal") <= 0)
            {
                myanim.SetInteger("State", 2);
                spriterend.flipX = true;
            }
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
            //animations
            //up
            if (Input.GetAxis("Vertical") >= 0)
            {
                myanim.SetInteger("State", 3);
                
            }
            //down
            if (Input.GetAxis("Vertical") <= 0)
            {
                myanim.SetInteger("State", 4);
                
            }
        }
        else
        { 
            velocity.y = Mathf.MoveTowards(velocity.y, speed * Input.GetAxis("Vertical"), deceleration * Time.fixedDeltaTime);
            myrb.velocity = new Vector2(velocity.x, velocity.y);
        }


        //this contains all collisions 
        Collider2D[] hits = Physics2D.OverlapBoxAll(transform.position + (Vector3)boxcollider.offset, boxcollider.size, 0);


        //check each collider
        foreach (Collider2D hit in hits)
        {
            //makesure not own collider
            if (hit == boxcollider)
                continue;

            

            //check if colliding
            ColliderDistance2D colliderDistance = hit.Distance(boxcollider);

            if (colliderDistance.isOverlapped)
            {
                transform.Translate((colliderDistance.pointA - colliderDistance.pointB) * 1.001f);
            }
        }
    }
}

