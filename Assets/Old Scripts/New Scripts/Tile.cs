using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Contains information about Occupant and Projectile above,
/// Handles Damage from projectile to Occupant
/// </summary>
public class Tile : MonoBehaviour
{
    public Occupant occupant;
    //public Projectile projectile;
    public bool occupied;
    public bool available;
    public bool hostile;
    public int damage;
    public Surface surface;
    public string tagToTriggerTile;

    // Start is called before the first frame update, Initializes Tile fields to neutral
    void Start()
    {
        available = true;
        hostile = false;
        damage = 0;
        surface = null;
        
    }

    //Damages occupant if tile is hostile w/ damage
    public void Damage()
    {
        if (occupant && hostile)
        {
            //occupant.TakeDamage(damage);
           // Debug.Log(projectile);
            //Destroy(projectile.gameObject);
            //Debug.Log(projectile);
           // Debug.Log("Taking Damage & Destroying projectile");
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (occupied)
        {
            Damage();
        }  
    }


    //On Projectile/Occupant enter sets tile fields appropriately
    void OnTriggerEnter2D(Collider2D hitInfo)
    {

        if (hitInfo.tag == tagToTriggerTile)
        {
           /* projectile = hitInfo.GetComponent<Projectile>();
            hostile = true;
            damage = projectile.getDamageValue();*/
        }
       
    }

    //Needs to have an if statment for surface and availability later
    void OnTriggerExit2D(Collider2D hitInfo)
    {
        //projectile = null;
        //occupant = null; Head teleporting out doesn't trigger
        //occupied = false;
        if(surface == null)
        {
            hostile = false;
            damage = 0;
        }
    }

}
