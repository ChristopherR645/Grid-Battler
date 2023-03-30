using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : Ability
{
    public GameObject sparksEffect;
    public int destroyTime;

    public override void Fire()
    {
        throw new System.NotImplementedException();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "EnemyProjectile")
        {
            Instantiate(sparksEffect, collision.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
        }

    }


    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, destroyTime);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
