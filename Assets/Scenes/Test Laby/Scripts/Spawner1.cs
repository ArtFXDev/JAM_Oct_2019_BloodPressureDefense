using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner1 : MonoBehaviour {

    //Transform currentWaypoint;
    public Transform currentWaypoint;
    //public Waypoint[] currentWaypointa;
    //public Waypoint[] currentWaypointb;
    //public Waypoint nextWaypoint;
    public GameObject Enemy1;
    public GameObject Enemy2;
    public static int EnemiesAlive = 0;

    //public Wave[] waves;

    //public Transform spawnPoint;

    public float timeBetweenWaves = 5f;
    private float countdown = 2f;

    //public Text waveCountdownText;

    public GameManager gameManager;

    private int waveIndex = 0;

    // Update is called once per frame
    void Update () {

        System.Random rnd = new System.Random();
        int witchWay = rnd.Next(1, 2);

        //if (witchWay == 1)
        //{
        //    currentWaypoint = currentWaypointa;
        //    //nextWaypoint = currentWaypointa;
        //}
        //else
        //{
        //    currentWaypoint = currentWaypointb;
        //    //nextWaypoint = currentWaypointb;
        //}

        if (EnemiesAlive > 0)
        {
            return;
        }

        //if (countdown <= 0f)
        //{
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
            return;
        //}

    }


    IEnumerator SpawnWave()
    {
        //PlayerStats.Rounds++;

        //Wave wave = waves[waveIndex];

        //EnemiesAlive = wave.count;
        EnemiesAlive = 20;

        for (int i = 0; i < gameManager.nbEnemy; i++)
        {
            if (gameManager.getcurrentEnemyType(i) == 2)
            {
                SpawnEnemy(Enemy2);
            }
            else
            {
                SpawnEnemy(Enemy1);
            }

            
            yield return new WaitForSeconds(5f);
        }

        waveIndex++;
    }

    void SpawnEnemy(GameObject enemy)
    {
        //Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);

        GameObject newEnemy = Instantiate(enemy, currentWaypoint.position, currentWaypoint.rotation);
        //newEnemy.GetComponent<Waypoint>().nextWaypoint = currentWaypoint.transform;

        //currentWaypoint = currentWaypoint.GetComponent<Waypoint>().nextWaypoint
        //GameObject newEnemy = Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
        //newEnemy.GetComponent<Bullet>().target = target;
    }
}
