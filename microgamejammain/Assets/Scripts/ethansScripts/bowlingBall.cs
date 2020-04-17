using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bowlingBall : MonoBehaviour
{
    /*public Transform spawnPoint;

    public GameObject ballPrefab;*/

    public float speed = 10f;
    public Rigidbody2D rb;
    int randz; 

    // Start is called before the first frame update
    void Start()
    {
        randz = Random.Range(45, 135);

        /*Instantiate(ballPrefab, spawnPoint.position, spawnPoint.rotation);*/
        transform.Rotate(0, 0, randz);
        rb.velocity = transform.up * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
