using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Event_ChangeRoom : MonoBehaviour
{
    public GameObject End;
    PlayerBasic playerBasic;
    bool IsTrigger = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (IsTrigger) return;
        if (other.tag == "Player")
        {
            IsTrigger = true;
            playerBasic = other.GetComponent<PlayerBasic>();
            StartCoroutine(StartEvent());
        }
    }

    IEnumerator StartEvent()
    {
        playerBasic.TriggerEvent();
        yield return new WaitForSecondsRealtime(0.5f);
        playerBasic.transform.DOMove(End.transform.position, 2f).SetEase(Ease.InQuad);
        yield return 0;
    }
}
