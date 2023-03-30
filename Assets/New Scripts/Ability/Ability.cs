using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class Ability : MonoBehaviour
{
    public GameObject player;
    protected float cooldown;
    protected int damage;
    [SerializeField] public LayerMask layerMask;
    public Transform firePoint;
    public GameObject shootingEffect;
    public GameObject impactEffect;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        firePoint = player.transform.Find("FirePoint");
        //shootingEffect = player.GetComponent(shootingEffect);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float getcooldown()
    {
        return cooldown;
    }

    public void setcooldown(float cd)
    {
        cooldown = cd;
    }

    public float getdamage()
    {
        return cooldown;
    }

    public void setdamage(float dmg)
    {
        cooldown = dmg;
    }

    public abstract void Fire();
    

    


}
