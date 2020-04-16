using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeLanters : MonoBehaviour
{
    public Sprite[] lanterns;
    SpriteRenderer spriterend;
    int x;
    bool running = true; 
    // Start is called before the first frame update
    void Start()
    {
        spriterend = GetComponent<SpriteRenderer>();
        StartCoroutine(randomlantern());
    }

    // Update is called once per frame
    void Update()
    {
        if (running == false)
        {
            StartCoroutine(randomlantern());
            running = true;
        }
    }

    IEnumerator randomlantern()
    {
        yield return new WaitForSecondsRealtime(Random.Range(.5f,3f));
        x = Random.Range(0, 3);
        spriterend.sprite = lanterns[x];
        running = false;
    }

}
