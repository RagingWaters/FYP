﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalPuzzleWin : MonoBehaviour
{
    public bool Correct1 = false;
    public bool Correct2 = false;
    public bool Correct3 = false;
    //public Item toyReward;
    private bool called = false;
    public GameObject correct;
    public GameObject player;
    public Transform Target;
    public GameObject sepiaFilter;
    public GameObject FadeTransition;
    private bool cd;
    

    // Start is called before the first frame update
    void Start()
    {
        cd = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Correct1 == true && Correct2 == true && Correct3 == true && called == false)
        {
            //Inventory.instance.Add(toyReward);
            print("Ez game boys");
            called = true;
            StartCoroutine(StopDialogue());
            Object.Instantiate(FadeTransition);
            sepiaFilter.SetActive(true);
        }

    }
    IEnumerator StopDialogue()
    {
        correct.SetActive(true);
        yield return new WaitForSeconds(4f);
        correct.SetActive(false);
        player.transform.position = Target.transform.position;
        yield return new WaitForSeconds(3f);
        cd = false;
    }
   
}
