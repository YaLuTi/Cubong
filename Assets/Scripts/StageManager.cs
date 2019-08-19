using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    // Start is called before the first frame update
    PlayerBasic playerBasic;
    [Header("*Debug Stage W & H")]
    public int StageWidth = 11;
    public int StageHeight = 11;

    public Vector2 PlayerPosition { get; private set; }

    void Start()
    {
        playerBasic = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBasic>();
        playerBasic.OnMove += SetPlayerPosition;
        StartCoroutine(SetStage());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetPlayerPosition()
    {
        PlayerPosition = playerBasic._Positon;
        Debug.Log(PlayerPosition);
    }

    IEnumerator SetStage()
    {
        // For Debug
        PlayerPosition.Set(5, 1);

        yield return 0;
    }
}
