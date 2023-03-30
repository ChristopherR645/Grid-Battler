using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 20f;
    public int damage = 50;
    public Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo){
        
        if(hitInfo.tag == "Enemy")
        {
            Enemy enemy = hitInfo.GetComponent<Enemy>();
            if(enemy != null)
            {
                enemy.TakeDamage(damage);
            }
            Destroy(gameObject);
        }else if(hitInfo.tag == "Border")
        {
            Destroy(gameObject);
        }
        else
        {
           // Debug.Log(hitInfo.name);
        }
        
    }

}
