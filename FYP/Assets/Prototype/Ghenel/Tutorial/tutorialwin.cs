﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorialwin : MonoBehaviour
{
    public bool Correct1 = false;
    public bool Correct2 = false;
    //public Item toyReward;
    private bool called = false;
    public GameObject correct;
    //public GameObject correct2;
    public GameObject player;
    private bool cd;
    public GameObject wrongPanel;
    public GameObject npc;
    public Animator anim;


    public Image dialogueImage;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        cd = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Correct1 == true && Correct2 == true && called == false)
        {
            //Inventory.instance.Add(toyReward);
            print("Ez game boys");
            called = true;
            StartCoroutine(StopDialogue());
            anim.Play("GateDoorOpen");
            //Object.Instantiate(FadeTransition);

        }
        else
        {
            //StartCoroutine(Wrong());
        }

    }
    IEnumerator StopDialogue()
    {
        dialogueImage.enabled = (true);
        correct.SetActive(true);
        yield return new WaitForSeconds(4f);
        correct.SetActive(false);
        dialogueImage.enabled = (false);
        yield return new WaitForSeconds(1f);
        Correct1 = false;
        //correct2.SetActive(true);
        //yield return new WaitForSeconds(4f);
        //correct2.SetActive(false);
        //yield return new WaitForSeconds(1f);
        npc.SetActive(false);

        cd = false;
    }

    IEnumerator Wrong()
    {
        wrongPanel.SetActive(true);
        yield return new WaitForSeconds(2f);
        wrongPanel.SetActive(false);

    }

}
