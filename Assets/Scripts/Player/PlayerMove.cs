using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerMove : MonoBehaviour
{
    PlayerBasic playerBasic;
    // Start is called before the first frame update
    void Start()
    {
        playerBasic = GetComponent<PlayerBasic>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(float h, float v)
    {
        if (h == 0 && v == 0) return;
        if(playerBasic.IsRoundAviable())
        {
            playerBasic._Move();
            transform.DOMove(new Vector3(transform.position.x + h, transform.position.y, transform.position.z + v), playerBasic.GameSpeed).SetEase(Ease.InQuint);
            Vector3 RotateMotion = new Vector3(90 * v, 0, 90 * -h);
            transform.DORotate(RotateMotion, playerBasic.GameSpeed, RotateMode.WorldAxisAdd).SetEase(Ease.InQuint);
        }
    }
}
