using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Character Controller
/// </summary>
public class RayCastMovement : MonoBehaviour{

    public Transform rayCaster;
    [SerializeField] public LayerMask layerMask;
    public float distance = 1f;
    public Occupant occupant;
    public Attacking attackingInstance;
    public char currentAbilityButton = 'e';

    

    // Start is called before the first frame update
    void Start()
    {
        //occupant.DetectTile();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D[] hitInfo;

        
        if (Input.GetKeyDown("w")){
             hitInfo = Physics2D.RaycastAll(rayCaster.position, Vector2.up, distance, layerMask);
            //Debug.Log("w");

            if (hitInfo.Length > 1)
            {
               // Debug.Log(hitInfo[1].transform.name); 
                if (hitInfo[1].transform.tag.Equals("BlueTile"))
                {
                    this.transform.position = hitInfo[1].transform.position;
                }
                
            }
        }

        if (Input.GetKeyDown("s"))
        {
            hitInfo = Physics2D.RaycastAll(rayCaster.position, Vector2.down, distance, layerMask);
            //Debug.Log("s");

            if (hitInfo.Length > 1)
            {
               // Debug.Log(hitInfo[1].transform.name);
                if (hitInfo[1].transform.tag.Equals("BlueTile"))
                {
                    this.transform.position = hitInfo[1].transform.position;
                }
            }
        }

        if (Input.GetKeyDown("a"))
        {
            //Debug.Log("a");
            hitInfo = Physics2D.RaycastAll(rayCaster.position, Vector2.left, distance, layerMask);


            if (hitInfo.Length > 1)
            {
                //Debug.Log(hitInfo[1].transform.name);
                if (hitInfo[1].transform.tag.Equals("BlueTile"))
                {
                    this.transform.position = hitInfo[1].transform.position;
                }
            }
        }

        if (Input.GetKeyDown("d"))
        {
            //Debug.Log("d");
            hitInfo = Physics2D.RaycastAll(rayCaster.position, Vector2.right, distance, layerMask);


            if (hitInfo.Length > 1)
            {
                //Debug.Log(hitInfo[1].transform.name);
                if (hitInfo[1].transform.tag.Equals("BlueTile"))
                {
                    this.transform.position = hitInfo[1].transform.position;
                }
            }
        }

        if (Input.GetButtonDown("Fire1"))
        {
            attackingInstance.AutoAttack();
        }

        if (Input.GetKeyDown("e"))
        {
            attackingInstance.ShootCurrentAbility();
        }
        occupant.UpdateTile();
    }
}
