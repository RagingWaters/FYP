﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject spawnActive;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            print("entrance");
            enemySpawner.startSpawn = true;
            spawnActive.SetActive(false);
        }
    }
}
