using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bowlingBall : MonoBehaviour
{
    

    public GameObject ballPrefab;
    

    // Start is called before the first frame update
    void Start()
    {
        Vector3 position = new Vector3(Random.Range(-6.0f, 6.0f), -4);

        Instantiate(ballPrefab, position, Quaternion.Euler(0.0f, 0.0f, Random.Range(45.0f, 135.0f)));
        /*transform.Rotate(0, 0, randz);*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
