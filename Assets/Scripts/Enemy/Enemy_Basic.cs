using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Enemy_Basic : MonoBehaviour
{
    [Header("Speed")]
    public float GameSpeed = 0.5f;

    [Header("Round Cooldown Setting")]
    float RoundCoolDown; // Player flip once = One Round   Set to avoid round over too fast
    float _RoundCoolDownValue;

    // Game Value
    public int MoveCount { get; private set; }
    public Vector2 _Positon { get; private set; }
    [Header("Game Value")]
    public bool IsOnEvent = false;
    
    public delegate void OnMoveDelegate();
    public event OnMoveDelegate OnMove;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(Vector2 position)
    {
        transform.DOMove(new Vector3(transform.position.x + position.x, transform.position.y, transform.position.z + position.y), GameSpeed).SetEase(Ease.InQuint);
        Vector3 RotateMotion = new Vector3(90 * position.y, 0, 90 * -position.x);
        transform.DORotate(RotateMotion, GameSpeed, RotateMode.WorldAxisAdd).SetEase(Ease.InQuint);
    }
}
