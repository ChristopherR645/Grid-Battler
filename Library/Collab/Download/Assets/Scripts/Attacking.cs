using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacking : MonoBehaviour
{
    [SerializeField] public LayerMask layerMask;
    public Transform firePoint;
    public GameObject shootingEffect;
    public GameObject impactEffect;
    public int autoAttackDmg = 1;
    public Projectile currentAbility;

    public void AutoAttack()
    {
        //Debug.Log("in AutoAttack");
        RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position, firePoint.transform.TransformDirection(Vector3.right), 20f, layerMask);
        Instantiate(shootingEffect, firePoint.position, Quaternion.identity);
        if (hitInfo)
        {
            Occupant occupant = hitInfo.transform.GetComponent<Occupant>();
            if(occupant != null)
            {
                occupant.TakeDamage(autoAttackDmg);
            }

            
            Instantiate(impactEffect, hitInfo.point, Quaternion.identity);
        }
    }

    public void ShootCurrentAbility()
    {
        Instantiate(currentAbility, firePoint.position, firePoint.rotation);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
