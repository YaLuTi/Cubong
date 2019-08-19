using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponController : MonoBehaviour
{
    [Header("Get Move")]
    PlayerBasic playerBasic;
    int MoveCount;

    List<WeaponBasic> weapons = new List<WeaponBasic>();
    // Start is called before the first frame update
    void Start()
    {
        playerBasic = GetComponent<PlayerBasic>();
        playerBasic.OnMove += SetValue;
        weapons.AddRange(GetComponentsInChildren<WeaponBasic>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetValue()
    {
        MoveCount = playerBasic.MoveCount;
        for(int i = 0; i < weapons.Count; i++)
        {
            weapons[i].Shoot();
        }
    }
}
