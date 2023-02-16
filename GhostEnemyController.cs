using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GhostEnemyController : MonoBehaviour
{
    public MyGameController MGC;
    public Rigidbody2D EnemyRB;
    public GameObject GhostEnemyClone;
    void Start()
    {
        MGC = GameObject.FindGameObjectWithTag("GameController").GetComponent<MyGameController>();
        if (MGC.EnemyPos != 0)
        {
            Instantiate(GhostEnemyClone, MGC.EnemySpawnLocations[0]);
        }
        if (MGC.EnemyPos != 1)
        {
            Instantiate(GhostEnemyClone, MGC.EnemySpawnLocations[1]);
        }
        if (MGC.EnemyPos != 2)
        {
            Instantiate(GhostEnemyClone, MGC.EnemySpawnLocations[2]);
        }
        if (MGC.EnemyPos != 3)
        {
            Instantiate(GhostEnemyClone, MGC.EnemySpawnLocations[3]);
        }
        EnemyRB.velocity = MGC.speed * transform.right;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(1);
        }
    }
}