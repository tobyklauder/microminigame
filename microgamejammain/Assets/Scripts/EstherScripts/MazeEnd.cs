/*
 * MazeEnd.cs
 * By: Esther Strathy
 * 4/15/2020
 * Description: win conditions of maze minigame
 */



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeEnd : MonoBehaviour
{
    int lanterns;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        print(timer);
        //if at end of stage and lanterns still are on the level lose a life
        if (lanterncount()!= 0 && Mathf.Floor(timer) == 5)
        {
            GameManager.lives -= 1;
            print(GameManager.lives);
            timer = 0;
            pickgame.delayedscenechange();
            
        }
        if (Mathf.Floor(timer)==5)
        {
            pickgame.delayedscenechange();
        }
    }

    int lanterncount()
    {
        lanterns = GameObject.FindObjectsOfType<MazeLanters>().Length;
        return lanterns;
    }
}
