using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_WeaponController : MonoBehaviour
{
    Enemy_Basic enemyBasic;
    int MoveCount;
    
    List<WeaponBasic> weapons = new List<WeaponBasic>();
    void Start()
    {
        enemyBasic = GetComponent<Enemy_Basic>();
        enemyBasic.OnMove += OnMove;
        weapons.AddRange(GetComponentsInChildren<WeaponBasic>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMove()
    {

    }
}
