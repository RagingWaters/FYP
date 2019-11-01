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
    public Animator anim;
    //public Animator anim;

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
        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.Space))
        {
            torchdooropt.SetActive(true);
            if (lm.currentKey == 1)
            {
                anim.Play("GotKeyDoorAnimation");
                //disabledDoor.SetActive(false);
                torchdooropt.SetActive(false);
            }
            else if (lm.currentKey == 0)
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
