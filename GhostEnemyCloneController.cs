using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GhostEnemyCloneController : MonoBehaviour
{
    public MyGameController MGC;
    public Rigidbody2D EnemyRB;
    void Start()
    {
        MGC = GameObject.FindGameObjectWithTag("GameController").GetComponent<MyGameController>();
        EnemyRB.velocity = MGC.speed * transform.right;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}