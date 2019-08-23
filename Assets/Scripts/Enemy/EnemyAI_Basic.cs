using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI_Basic : MonoBehaviour
{
    StageManager stageManager;

    Vector2 PlayerPosition;
    Vector2[] Map;
    List<Enemy_Basic> enemies = new List<Enemy_Basic>();

    void Start()
    {
        stageManager = GetComponent<StageManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
