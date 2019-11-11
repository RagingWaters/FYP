using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandlePickUp : MonoBehaviour
{

    public LevelManager theLevelManager;
    public int Candles;
    public GameObject originalSpawn;
    public Transform newSpawnEnemy;


    // Start is called before the first frame update
    void Start()
    {
        theLevelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Interact"))
            {
                theLevelManager.AddCandles(Candles);
                originalSpawn.transform.position = newSpawnEnemy.position;
                enemySpawner.startSpawn = true;
                print("added Candles");
                Destroy(gameObject);
            }
        }
    }
}
