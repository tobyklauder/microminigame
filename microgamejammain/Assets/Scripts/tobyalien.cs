using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tobyalien : MonoBehaviour
{
    Rigidbody2D myrb;
    int dir = 2;
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
            Debug.Log("firechance is 3");
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
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - 0.50f, this.transform.position.z);
            if (dir == 2)
            {
                dir = -2;
                myrb.velocity = new Vector2(dir, 0);
            }
            else if (dir == -2)
            {
                dir = 2;
                myrb.velocity = new Vector2(dir, 0);
            }
        }

    }
}
