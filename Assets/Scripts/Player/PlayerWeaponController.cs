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
        for (int i = 0; i < weapons.Count; i++)
        {
            /*
            float Rx = transform.rotation.eulerAngles.x;
            float Ry = transform.rotation.eulerAngles.y;
            if (Rx == 0)
            {
                switch (Ry)
                {
                    case 0:
                        Debug.Log(1);
                        break;
                    case 90:
                        Debug.Log(2);
                        break;
                    case 180:
                        Debug.Log(3);
                        break;
                    case 270:
                        Debug.Log(4);
                        break;
                    default:
                        break;
                }
            }else
            {
                if(Ry == 0)
                {
                    Debug.Log(5);
                }
                else
                {
                    Debug.Log(6);
                }
            }*/
        }
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
