using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AutoAttackDefault : Ability
{
    public void AutoAttack()
    {
        damage = 1;
        cooldown = 0;

        
        RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position, firePoint.transform.TransformDirection(Vector3.right), 20f, layerMask);
        Instantiate(shootingEffect, firePoint.position, Quaternion.identity);
        if (hitInfo)
        {
            Enemy Enemy = hitInfo.transform.GetComponent<Enemy>();
            if (Enemy != null)
            {
                Enemy.TakeDamage(this.damage);
            }


            Instantiate(impactEffect, hitInfo.point, Quaternion.identity);
        }
    }
    public override void Fire()
    {
        AutoAttack();
    }
}
