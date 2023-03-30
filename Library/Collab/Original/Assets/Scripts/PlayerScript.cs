using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public Transform rayCasterMovement;
    [SerializeField] public LayerMask layerMask;
    public float distance;
    public int numToIgnore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D[] hitInfo;


        if (Input.GetKeyDown("w"))
        {
            hitInfo = Physics2D.RaycastAll(rayCasterMovement.position, Vector2.up, distance, layerMask);
            if (hitInfo[numToIgnore].transform.tag.Equals("BlueTile"))
                {
                    this.transform.position = hitInfo[numToIgnore].transform.position;
                }
        }

        if (Input.GetKeyDown("s"))
        {
            hitInfo = Physics2D.RaycastAll(rayCasterMovement.position, Vector2.down, distance, layerMask);

                if (hitInfo[numToIgnore].transform.tag.Equals("BlueTile"))
                {
                    this.transform.position = hitInfo[numToIgnore].transform.position;
                }
        }

        if (Input.GetKeyDown("a"))
        {
            hitInfo = Physics2D.RaycastAll(rayCasterMovement.position, Vector2.left, distance, layerMask);

                if (hitInfo[numToIgnore].transform.tag.Equals("BlueTile"))
                {
                    this.transform.position = hitInfo[numToIgnore].transform.position;
                }
        }

        if (Input.GetKeyDown("d"))
        {
            hitInfo = Physics2D.RaycastAll(rayCasterMovement.position, Vector2.right, distance, layerMask);

                if (hitInfo[numToIgnore].transform.tag.Equals("BlueTile"))
                {
                    this.transform.position = hitInfo[numToIgnore].transform.position;
                }
        }
    }
}
