using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hunterBallStart : MonoBehaviour
{
    public float Speed = 0.0f;
    private int OneStop = 0;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, Speed);
    }

    // Update is called once per frame
    void Update()
    {
        Stop();
    }

    private void Stop()
    {
        if (Input.GetKey(KeyCode.Space) && OneStop == 0)
        {
            OneStop++;
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            if((gameObject.transform.position.x >= 2 || gameObject.transform.position.x <= -2) || ((gameObject.transform.position.y >= 2 || gameObject.transform.position.y <= -2)))
            {
                print("you lose");
            }
        }
    }
}
