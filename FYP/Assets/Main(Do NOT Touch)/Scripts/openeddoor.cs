﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class openeddoor : MonoBehaviour
{

    public GameObject openedooropt;
    public PlayerControls Player;
   // public GameObject disableDoor;
    public Animator anim;
    public GameObject open;
    public bool opendoor = false;
    public AudioManager am;

    public Image doorHandleUI;

    // Start is called before the first frame update
    void Start()
    {
        
        doorHandleUI.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider other)
    {
        if(opendoor == false)
        {
            //openedooropt.SetActive(true);
            doorHandleUI.enabled = true;
            if (other.gameObject.tag == "Player")
            {
                //openedooropt.SetActive(true);
                if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Interact"))
                {
                    anim.Play("GateDoorOpen");
                    am.Door();
                    Debug.Log("dooropen");
                    //disableDoor.SetActive(false);

                    //openedooropt.SetActive(false);
                    open.SetActive(false);
                    opendoor = true;

                    doorHandleUI.enabled = false;
                }
            }
        } 
       
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //openedooropt.SetActive(false);

            doorHandleUI.enabled = false;
        }
    }
}