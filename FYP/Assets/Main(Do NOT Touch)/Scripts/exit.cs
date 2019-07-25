using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour
{
    public GameObject CurrentLevelSpawner1;
    public GameObject CurrentLevelSpawner2;

    //public GameObject light1;

    private void OnTriggerExit(Collider other)
    {
        CurrentLevelSpawner1.SetActive(false);
        CurrentLevelSpawner2.SetActive(false);
        enemySpawner.startSpawn = false;
       // light1.SetActive(false);
        // if (other.gameObject.tag.Equals("Enemy"));
        // {
        //   Destroy(other.gameObject);
        // }
    }
}
