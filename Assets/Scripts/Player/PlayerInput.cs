using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public PlayerMove playerMove;
    // Start is called before the first frame update
    void Start()
    {
        playerMove = GetComponent<PlayerMove>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        playerMove.Move(h, v);
    }
}
