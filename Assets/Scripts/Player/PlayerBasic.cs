using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBasic : MonoBehaviour
{
    [Header("Player Component")]
    PlayerInput _Input;

    [Header("Player Speed")]
    [SerializeField]
    public float GameSpeed = 0.5f;

    [Header("Round Cooldown Setting")]
    float RoundCoolDown; // Player flip once = One Round   Set to avoid round over too fast
    float _RoundCoolDownValue;

    // Game Value
    public int MoveCount { get; private set; }
    public Vector2 _Positon { get; private set; }
    [Header("Game Value")]
    public bool IsOnEvent = false; // Maybe need enum to know which kind of event?

    public delegate void OnVariableChangeDelegate();
    public event OnVariableChangeDelegate OnMove;

    // Start is called before the first frame update
    void Start()
    {
        _RoundCoolDownValue = GameSpeed;
        RoundCoolDown = 0;
        MoveCount = 0;
        _Input = GetComponent<PlayerInput>();
        _Positon = new Vector2(5, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if(RoundCoolDown < _RoundCoolDownValue)RoundCoolDown += Time.deltaTime;
    }

    public bool IsRoundAviable()
    {
        if(RoundCoolDown >= _RoundCoolDownValue)
        {
            RoundCoolDown = 0;
            return true;
        }
        return false;
    }

    public void _Move(float h, float v)
    {
        _Positon += new Vector2(h, v);
        StartCoroutine(Delay_Move());
    }

    public void TriggerEvent()
    {
        IsOnEvent = true;
        _Input.enabled = false; // Use easiest solution temporarily  Fix when I need  more complex system?
    }

    public void EndEvent()
    {
        IsOnEvent = false;
        _Input.enabled = true;
    }

    IEnumerator Delay_Move()
    {
        yield return new WaitForSecondsRealtime(GameSpeed);
        MoveCount++;
        OnMove();
    }
}
