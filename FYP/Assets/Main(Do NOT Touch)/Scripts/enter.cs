using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enter : MonoBehaviour
{
    public GameObject Level1Spawner1;
    public GameObject Level1Spawner2;
    public int setLevel,setMax;
    private void OnTriggerEnter(Collider other)
    {
        enemySpawner.currentLevel = setLevel;
        enemySpawner.maxLevel = setMax;
        enemySpawner.startSpawn = true;
        Level1Spawner1.SetActive(true);
        Level1Spawner2.SetActive(true);
    }
}
