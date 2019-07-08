using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public enum SpawnState { SPAWNING, WAITING, COUNTING }; //state of spawner - must change name

    [System.Serializable] //allows us to change the values inside unity instead of dw

    public class Wave
    {
        public string name; //variables of wave
        public Transform enemy;
        public int count;
        public float rate;

    }

    public Wave[] waves;
    private int nextWave = 0;

    public Transform[] spawnPoints;

    public float timeBetweenWaves = 5f;
    public float waveCountdown; //can change to private

    private float searchCountdown = 1f;

    private SpawnState state = SpawnState.COUNTING;

    public static bool startSpawn;

    public static int currentLevel,maxLevel;

    // Start is called before the first frame update
    void Start()
    {

        if (spawnPoints.Length == 0)
        {
            Debug.LogError("No spawn points referrenced");
        }

        waveCountdown = timeBetweenWaves;
    }

    // Update is called once per frame
    void Update()
    {

        if (state == SpawnState.WAITING)
        {
            if (!EnemyIsAlive())    //check if enemies are still alive
            {
                //Begin new round
                //Debug.Log("Wave Completed");
                //return;
                waveCompleted();
            }
            else
            {
                return;
            }
        }
        if (waveCountdown <= 0)
        {
            if (state != SpawnState.SPAWNING)
            {

                StartCoroutine(SpawnWave(waves[nextWave]));

                //Start spawning wave
            }
        }

        else
        {
           if(startSpawn) waveCountdown -= Time.deltaTime;
        }
    }

    void waveCompleted()
    {
        Debug.Log("Wave Completed");

        state = SpawnState.COUNTING;
        waveCountdown = timeBetweenWaves;

        if (nextWave + 1 > waves.Length - 1)
        {
            nextWave = 0;
            Debug.Log("waves done, loooping");
        }
        else
        {

            nextWave++;
        }
    }

    bool EnemyIsAlive() //check^
    {

        searchCountdown -= Time.deltaTime;
        if (searchCountdown <= 0f)
        {
            searchCountdown = 1f;
            //if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0); (for specific secs)
            if (GameObject.FindGameObjectWithTag("Enemy") == null)
            {
                return false;
            }
        }
        return true;
    }

    IEnumerator SpawnWave(Wave _wave)  //waiting seconds for each state
    {
        Debug.Log("Spawning Wave:" + _wave.name);

        state = SpawnState.SPAWNING;

        for (int i = 0; i < _wave.count; i++)
        {
            SpawnEnemy(_wave.enemy);
            yield return new WaitForSeconds(1f / _wave.rate);
        }

        state = SpawnState.WAITING;

        yield break; //end IE
    }

    void SpawnEnemy(Transform _enemy) //spawn enemy
    {
        Debug.Log("Spawning Enemy:" + _enemy.name);

        Transform _spawnPoint = spawnPoints[Random.Range(currentLevel, maxLevel + 1)];
        Instantiate(_enemy, _spawnPoint.position, _spawnPoint.rotation);
    }
}
