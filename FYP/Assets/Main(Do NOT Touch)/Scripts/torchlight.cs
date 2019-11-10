﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torchlight : MonoBehaviour
{

    public LevelManager theLevelManager;
    public int torchValue;
    public GameObject dialogue;
    public GameObject dgameObject;
    public LightAdjuster lightAdjust;

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
                //enemySpawner.startSpawn = true; 
                theLevelManager.AddTorch(torchValue);
                dialogue.SetActive(true);
                dgameObject.SetActive(true);
                lightAdjust.Range();
                print("added torch, spawning ghost");
                Destroy(gameObject);
            }
        }
    }
    
}