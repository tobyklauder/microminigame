using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeLanters : MonoBehaviour
{
    public Sprite[] lanterns;
    SpriteRenderer spriterend;
    int x; 
    // Start is called before the first frame update
    void Start()
    {
        spriterend = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator randomlantern()
    {
        x = Random.Range(0, 3);
        spriterend.sprite = lanterns[x];
        yield return new WaitForSecondsRealtime(1f);
    }

}
