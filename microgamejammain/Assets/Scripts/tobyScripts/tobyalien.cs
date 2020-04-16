using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tobyalien : MonoBehaviour
{
    Rigidbody2D myrb;
    [SerializeField, Tooltip("both direction and speed.")]
    int dir = 3;
    int firechance;
    [SerializeField, Tooltip("Object aliens fire")]
    public GameObject bulletone;
    // Start is called before the first frame update
    void Start()
    {
        myrb = GetComponent<Rigidbody2D>();
        myrb.velocity = new Vector2(dir, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        firechance = Random.Range(1, 200);
        if (firechance == 3)
        {
            GameObject bullet = Instantiate(bulletone, this.transform.position, transform.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -20, 0);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "bullet")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);

        }
        if (collision.gameObject.tag == "wall")
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - 1f, this.transform.position.z);
            if (dir > 0)
            {
                dir++;
                dir = -dir;
                myrb.velocity = new Vector2(dir, 0);
            }
            else if (dir < 0)
            {
                dir = Mathf.Abs(dir) + 1;
                myrb.velocity = new Vector2(dir, 0);
            }
        }

    }
}
