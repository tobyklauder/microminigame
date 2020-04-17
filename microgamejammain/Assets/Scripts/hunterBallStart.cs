using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hunterBallStart : MonoBehaviour
{
    //All the Variables
    public float Speed = 0.0f;
    private int OneStop = 0;
    private int timeLoss = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Starting the Ball's Movement and setting the Basic Speed for that round
        GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, Speed);
    }

    // Update is called once per frame
    void Update()
    {
        //The two functions used for the game
        Stop();
        AutoLose();
    }

    //What happens when the player hits the Spacebar
    private void Stop()
    {
        if (Input.GetKey(KeyCode.Space) && OneStop == 0)
        {
            //Increase speed for next round, make sure the player can't re-input spacebar, and stopping speed
            Speed++;
            OneStop++;
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            //Checking for Failure and life loss
            if((gameObject.transform.position.x >= 2 || gameObject.transform.position.x <= -2) || ((gameObject.transform.position.y >= 2 || gameObject.transform.position.y <= -2)))
            {
                print("you lose");
                GameManager.lives--;
            }
        }
    }

    //Preventing the player from not pressing spacebar and winning anyways
    private void AutoLose()
    {
        if(gameObject.transform.position.x > 10 && timeLoss == 0)
        {
            timeLoss++;
            GameManager.lives--;
            print("you lose");
        }
    }
}
