using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class MyGameController : MonoBehaviour
{
    [Header("Enemy Settings")]
    public int EnemyPos;
    private int EnemyType;
    public Transform[] Enemies;
    public Transform[] EnemySpawnLocations;
    [Header("Difficulty Settings")]
    public int Difficulty;
    public float SpawnRate = 5;
    public float speed;
    [Header("Gameplay")]
    public bool RandPos;
    public bool MouseControls;
    [Header("Win Condition")]
    public bool Timer;
    public int Points;
    public int PointsToWin;
    public float TimeRemaining;
    [Header("UI")]
    public TextMeshProUGUI Display;
    void Start()
    {
        if (RandPos == false)
        {
            switch (Difficulty)
            {
                case (1):
                    break;
            }
        }
        else
        {
            StartCoroutine(RandomEnemies());
        }
    }
    IEnumerator RandomEnemies()
    {
        while (true)
        {
            EnemyPos = Random.Range(0, 4);
            EnemyType = Random.Range(0, 3);
            Instantiate(Enemies[EnemyType], EnemySpawnLocations[EnemyPos]);

            yield return new WaitForSeconds(SpawnRate);
        }
    }
    private void Update()
    {
        if (Timer)
        {
            if (TimeRemaining >= 0)
            {
                TimeRemaining -= Time.deltaTime;
            }
            else
            {
                SceneManager.LoadScene(2);
            }
            Display.text = TimeRemaining.ToString();
            float seconds = Mathf.FloorToInt(TimeRemaining % 60);
            Display.text = string.Format("{0}", seconds);
        }
        else if (Points >= PointsToWin)
        {
            SceneManager.LoadScene(2);
        }
    }
}