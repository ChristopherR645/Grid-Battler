using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Rigidbody2D rb;
    //public Transform tileChecker; tile check is handled by the tile currently
    public int damageValue = 0;
    //public string affectedTiles = "BlueTiles";
    public Surface surfaceEffect;
    public bool right;
    public int speed;
    public bool counterable;

    // Start is called before the first frame update, sends Projectile Left
    void Start()
    {
        if(right == true)
        {
            rb.velocity = transform.right * speed;
        }
        else
        {
            rb.velocity = -transform.right * speed;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        RaycastHit2D hitInfo = Physics2D.Raycast(tileChecker.position, Vector3.back, 2);

        if(hitInfo.collider.gameObject.tag == ("BlueTile"))
        {
            Tile currentTile = hitInfo.collider.gameObject.GetComponent<Tile>();
            currentTile.damage = damageValue;
            currentTile.hostile = true;
        }
        */
    }

    public int getDamageValue()
    {
        return damageValue;
    }
}
