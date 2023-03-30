using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public Occupant occupant;
    RaycastHit2D[] hitInfo;
    public Transform rayCaster;
    public float distance = 3f;
    [SerializeField] public LayerMask layerMask;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        occupant.UpdateTile();
    }

    
    public void Up()
    {
            hitInfo = Physics2D.RaycastAll(rayCaster.position, Vector2.up, distance, layerMask);
        if (hitInfo.Length > 1)
        {
            Debug.Log(hitInfo[1].transform.name);
            if (hitInfo[1].transform.tag.Equals("OrangeTile"))
            {
                this.transform.position = hitInfo[1].transform.position;
            }

       }
       else {
            Debug.Log("fix this");
                }
    }

    public void Down()
        {
            hitInfo = Physics2D.RaycastAll(rayCaster.position, Vector2.down, distance, layerMask);
            //Debug.Log("s");

            if (hitInfo.Length > 1)
            {
               // Debug.Log(hitInfo[1].transform.name);
                if (hitInfo[1].transform.tag.Equals("OrangeTile"))
                {
                    this.transform.position = hitInfo[1].transform.position;
                }
            }
        }

    public void Left()
        {
            //Debug.Log("a");
            hitInfo = Physics2D.RaycastAll(rayCaster.position, Vector2.left, distance, layerMask);


            if (hitInfo.Length > 1)
            {
                //Debug.Log(hitInfo[1].transform.name);
                if (hitInfo[1].transform.tag.Equals("OrangeTile"))
                {
                    this.transform.position = hitInfo[1].transform.position;
                }
            }
        }

    public void Right()
        {
            //Debug.Log("d");
            hitInfo = Physics2D.RaycastAll(rayCaster.position, Vector2.right, distance, layerMask);


            if (hitInfo.Length > 1)
            {
                //Debug.Log(hitInfo[1].transform.name);
                if (hitInfo[1].transform.tag.Equals("OrangeTile"))
                {
                    this.transform.position = hitInfo[1].transform.position;
                }
            }
        }
}
