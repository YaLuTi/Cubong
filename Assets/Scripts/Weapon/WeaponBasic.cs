using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBasic : MonoBehaviour
{
    [Header("Bullet")]
    public GameObject Bullet;
    public Transform GunMuzzle;
    [Header("RoundCount")]
    int RoundCount = 0;
    int _RoundCountValue = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void Shoot()
    {

    }
}
