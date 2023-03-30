using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Occupant : MonoBehaviour
{
    [SerializeField] public LayerMask layerMask;
    public int health;
    //var[] attacks;
    //var currentAttack;
    public GameObject deathEffect;
    public Transform rayCasterTileDetection;
    public Tile previousTile = null;
    public Transform firePoint;
    public string tagOfTile;
    public Health healthBar;
    public EnemyHP enemyHP;
    public bool isPlayer;

    void Start()
    {
        previousTile = returnTile();
        if(isPlayer == true) {
            healthBar.SetMaxHealth(health);
        }
        if(isPlayer == false) {
            enemyHP.SetMaxHealth(health);
        }
        

    }

    public void Update() {
        if(isPlayer == true) {
            healthBar.SetCurrentHealth(health);
        }
       if(isPlayer == false) {
            enemyHP.SetHealth(health);
        }
    }

    //returns the tile behind Occupant
    public Tile returnTile()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(rayCasterTileDetection.position, Vector3.back, 2);
        if (hitInfo != false)
        {
            Tile currentTile = hitInfo.collider.gameObject.GetComponent<Tile>();
            return currentTile;
        }
        return null;
    }

    //Updates the Tile behind Occupant
    public void UpdateTile()
    {
        
       
        RaycastHit2D hitInfo = Physics2D.Raycast(rayCasterTileDetection.position, Vector3.back, 2);
        if (hitInfo != false)
        {

            //if Occupant is on a BlueTile/OrangeTile, update the Tile fields, and check if damage is applied
            // if (hitInfo.collider.gameObject.tag == ("BlueTile"))
            //{

            //Debug.Log(hitInfo.transform.name);

                Tile currentTile = hitInfo.collider.gameObject.GetComponent<Tile>();
                if (currentTile.name != previousTile.name)// if tiles are different update tiles and set previous tile to current
                {
                    previousTile.occupant = null;
                    previousTile.occupied = false;
                    currentTile.occupant = this;
                    currentTile.occupied = true;
                    previousTile = currentTile;
                }
                else //starting - if previousTile and currentTile are the same occupy it
                {
                    currentTile.occupant = this;
                    currentTile.occupied = true;
                }

            //}
        }
    }

    public void SwapAttack()
    {

    }

    //Has Occupant take specified damage
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    //Spawns deathEffect at occupants location
    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
