using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public int rand = 0;
    public Transform firePoint;
    public GameObject energyPrefab;
    public GameObject deathEffect;

    private float timeBtwShots;
    public float startTimeBtwShots;
    public GameObject projectile;

    void Start()
    {
    }

    void Update()
    {
    }

    // Start is called before the first frame update
    public void TakeDamage(int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            Die();
        }
        
    }

   
    void Attack()
    {

    }

    // Update is called once per frame
    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
    }
}
