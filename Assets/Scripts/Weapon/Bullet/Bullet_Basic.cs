using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Basic : MonoBehaviour
{
    [Header("Basic Bullet Setting")]
    [SerializeField]
    public float BulletMoveSpeed;

    public GameObject HitParticle;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SetSpawner(GameObject spawner)
    {
        Physics.IgnoreCollision(spawner.GetComponent<Collider>(), this.GetComponent<Collider>(), false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(1);
        Destroy(this.gameObject);
    }
}
