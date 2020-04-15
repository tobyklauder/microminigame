using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tobybullet : MonoBehaviour
{

    [SerializeField, Tooltip("Player Tank")]
    GameObject player;
    [SerializeField, Tooltip("Distance to Tank")]
    float distance;  
    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, this.transform.position) > 50)
        {
            Destroy(gameObject);
        }
    }
}
