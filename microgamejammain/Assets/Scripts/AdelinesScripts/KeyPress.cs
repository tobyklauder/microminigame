using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPress : MonoBehaviour
{
    public GameObject key;
    public AudioSource audioSource;
    public KeyCode keybind;
    public Color color;
    public GameObject pattern;
    public int keyNumber;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keybind))
        {
            audioSource.Play();
            key.GetComponent<SpriteRenderer>().color = color;
            pattern.GetComponent<patternManager>().onKeyPress(keyNumber);
        }
        if (Input.GetKeyUp(keybind))
        {
            key.GetComponent<SpriteRenderer>().color = Color.white;
        }
    }

    
}
