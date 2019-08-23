using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Pistol : WeaponBasic
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override bool Shoot()
    {
        if (!base.Shoot())
        {
            return false;
        }
        GameObject b = Instantiate(Bullet, GunMuzzle.position, GunMuzzle.rotation);
        b.GetComponent<Bullet_Basic>().SetSpawner(transform.parent.gameObject);
        return true;
    }
}
