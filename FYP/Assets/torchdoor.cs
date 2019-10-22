﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torchdoor : MonoBehaviour
{

    public GameObject torchdooropt;
    public PlayerControls Player;
    public GameObject warning;
    public GameObject disabledDoor;
    public LevelManager lm;

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
            torchdooropt.SetActive(true);
            if (Input.GetKeyDown(KeyCode.P) && lm.currentKey == 1)
            {
                disabledDoor.SetActive(false);
                torchdooropt.SetActive(false);
            }
            else
            {
                warning.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            torchdooropt.SetActive(false);
            warning.SetActive(false);
        }
    }
}
