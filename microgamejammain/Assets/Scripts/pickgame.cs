using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
public class pickgame : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // TimerCoroutine();
        Invoke("delayedscenechange", 5f);
    }
  
 

    public static void delayedscenechange()
    {
        SceneManager.LoadScene(Random.Range(0, 9));
    }
}
