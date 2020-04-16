using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerbar : MonoBehaviour
{
    float time = 5; 
    public GameObject timer;
    Vector3 localscale;
    // Start is called before the first frame update
    void Start()
    {
        localscale = timer.transform.localScale;    
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
            localscale.x = time;
            timer.transform.localScale = localscale; 
        }
    }
}
