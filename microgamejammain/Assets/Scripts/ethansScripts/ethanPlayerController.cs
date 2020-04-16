using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ethanPlayerController : MonoBehaviour
{

    public Rigidbody2D rb;
    public float speed = 3f;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);

            animator.SetBool("pinMoving", true);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);

            animator.SetBool("pinMoving", true);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);

            animator.SetBool("pinMoving", true);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);

            animator.SetBool("pinMoving", true);
        }

        else
        {
            animator.SetBool("pinMoving", false);
        }
    }
}