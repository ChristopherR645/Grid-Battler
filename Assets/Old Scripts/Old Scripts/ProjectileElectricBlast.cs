using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileElectricBlast : MonoBehaviour
{

    public float speed = 20f;
    public int damage = 50;
    public Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = -transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        //Debug.Log(hitInfo.tag);
       /* if (hitInfo.tag == "Player")
        {
            Debug.Log("hit Player");
            Player player = hitInfo.GetComponent<player>();
            if (player != null)
            {
                player.TakeDamage(damage);
            }
            Destroy(gameObject);
        }
        else if (hitInfo.tag == "Border")
        {
            Debug.Log("should destroy");
            Destroy(gameObject);
        }
        else
        {
            //Debug.Log(hitInfo.name);
        }*/

    }

}
