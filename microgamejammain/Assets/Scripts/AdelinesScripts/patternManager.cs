using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patternManager : MonoBehaviour
{
    public int[] pattern = new int[8];
    private int farthestIndex;
    public GameObject letterA;
    public GameObject letterB;
    public GameObject letterC;
    public GameObject letterD;
    public GameObject letterE;
    public GameObject letterF;
    public GameObject letterG;
    private GameObject[] letters = new GameObject[8];
    private bool inGame = true;

    // Start is called before the first frame update
    void Start()
    {
        farthestIndex = -1;
        for (int i = 0; i < pattern.Length; i++)
        {
            if (pattern[i] == 1)
            {
                letters[i] = Instantiate(letterC, new Vector3(-3.5f + (float)i, 3), new Quaternion(0, 0, 0, 0));
            }
            if (pattern[i] == 2)
            {
                letters[i] = Instantiate(letterD, new Vector3(-3.5f + (float)i, 3), new Quaternion(0, 0, 0, 0));
            }
            if (pattern[i] == 3)
            {
                letters[i] = Instantiate(letterE, new Vector3(-3.5f + (float)i, 3), new Quaternion(0, 0, 0, 0));
            }
            if (pattern[i] == 4)
            {
                letters[i] = Instantiate(letterF, new Vector3(-3.5f + (float)i, 3), new Quaternion(0, 0, 0, 0));
            }
            if (pattern[i] == 5)
            {
                letters[i] = Instantiate(letterG, new Vector3(-3.5f + (float)i, 3), new Quaternion(0, 0, 0, 0));
            }
            if (pattern[i] == 6)
            {
                letters[i] = Instantiate(letterA, new Vector3(-3.5f + (float)i, 3), new Quaternion(0, 0, 0, 0));
            }
            if (pattern[i] == 7)
            {
                letters[i] = Instantiate(letterB, new Vector3(-3.5f + (float)i, 3), new Quaternion(0, 0, 0, 0));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onKeyPress(int number)
    {
        if (inGame)
        {
            if (pattern[farthestIndex + 1] == number)
            {
                farthestIndex++;
                letters[farthestIndex].GetComponent<SpriteRenderer>().color = Color.green;
                if (farthestIndex + 1 == pattern.Length)
                {
                    //win this minigame
                    for (int i = 0; i < pattern.Length; i++)
                    {
                        letters[i].GetComponent<SpriteRenderer>().color = Color.blue;
                    }
                    inGame = false;
                }
            }
            else
            {
                for (int i = 0; i <= farthestIndex; i++)
                {
                    letters[i].GetComponent<SpriteRenderer>().color = Color.white;
                }
                farthestIndex = -1;
            }
        }
    }
}
