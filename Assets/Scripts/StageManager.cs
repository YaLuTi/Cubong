using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    PlayerBasic playerBasic;
    [Header("*Debug Stage W & H")]
    public int StageWidth = 11;
    public int StageHeight = 11;

    // Get(Spawn) Enemies
    List<Enemy_Basic> enemies = new List<Enemy_Basic>();

    public Vector2 PlayerPosition { get; private set; }

    void Start()
    {
        playerBasic = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBasic>();
        playerBasic.OnMove += OnPlayerMove;
        StartCoroutine(SetStage());

        // Debug
        /*foreach(GameObject g in GameObject.FindGameObjectsWithTag("Enemies"))
        {
            enemies.Add(g.GetComponent<Enemy_Basic>());
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnPlayerMove()
    {
        PlayerPosition = playerBasic._Positon;

        for(int i = 0; i < enemies.Count; i++)
        {

        }
    }

    IEnumerator SetStage()
    {
        // For Debug
        PlayerPosition.Set(5, 1);

        yield return 0;
    }
}
