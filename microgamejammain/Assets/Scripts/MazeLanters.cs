/*
 * MazeLanters.cs (yes ik i spelt it wrong but i dont wanna fix it)
 * By: Esther Strathy
 * 4/16/2020
 * Description: lantern blinking, spawning, and destroy
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeLanters : MonoBehaviour
{
    public Sprite[] lanterns;
    SpriteRenderer spriterend;
    int x;
    bool running = true;
    GameObject thisobj;
    private BoxCollider2D boxcollider;
    // Start is called before the first frame update
    void Start()
    {
        boxcollider = GetComponent<BoxCollider2D>();
        thisobj = GetComponent<GameObject>(); 
        spriterend = GetComponent<SpriteRenderer>();
        StartCoroutine(randomlantern());
        lanternspawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (running == false)
        {
            StartCoroutine(randomlantern());
            running = true;
        }
        collision();
    }

    IEnumerator randomlantern()
    {
        yield return new WaitForSecondsRealtime(Random.Range(.5f,3f));
        x = Random.Range(0, 3);
        spriterend.sprite = lanterns[x];
        running = false;
    }

    void collision()
    {
        //this contains all collisions 
        Collider2D[] hits = Physics2D.OverlapBoxAll(transform.position + (Vector3)boxcollider.offset, boxcollider.size, 0);

        foreach (Collider2D hit in hits)
        {
            //makesure not own collider
           if (hit == boxcollider)
               continue;



            //check if colliding
            ColliderDistance2D colliderDistance = hit.Distance(boxcollider);

            if (colliderDistance.isOverlapped)
            {
                Destroy(this.gameObject);
                print("destroyed");
            }
        }

    
    }


    void lanternspawn()
    {
        //select quadrant
    }
}
