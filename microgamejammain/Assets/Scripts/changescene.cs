using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
public class changescene : MonoBehaviour
{
    [SerializeField, Tooltip("Scene to load")]
    static string scene;
    static public void changescenes()
    {
        SceneManager.LoadScene(scene); 
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
