using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorial : MonoBehaviour
{
    public GameObject dialogue1;
    public GameObject dialogue2;
    public GameObject dialogue3;
    public GameObject key1;
    public GameObject key2;
    public GameObject key3;
    public GameObject box1;
    public GameObject box2;




    public Image dialogueImage;

    public Footsteps footsteps;

    //public DialogueManager theDialogueManager;
    public static bool isTalking;
    PlayerControls pc;
    public tutorialwin tw;
    bool third = false;
    bool stated;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (tw.Correct1 == true && third == false) 
            {
                StartCoroutine(thirdDialogue());
            }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && isTalking == false)
        {
            if (Input.GetKeyDown(KeyCode.Space) && stated == false || Input.GetButtonDown("Interact") && stated == false)
            {
                //pc.freezeMovement = true;
                footsteps.enabled = false;
                isTalking = true;
                dialogue1.SetActive(true);
                key1.SetActive(true);
                key2.SetActive(true);
                key3.SetActive(true);
                box1.SetActive(true);
                dialogueImage.enabled = (true);
                stated = true;
                StartCoroutine(ContinueDialogue());

                Debug.Log("paused");
            }
          
            //else if (tw.Correct1 == true && third == false) 
           // {
            //    StartCoroutine(thirdDialogue());
           // }

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            dialogue1.SetActive(false);
            dialogue2.SetActive(false);
            dialogueImage.enabled = (false);
            isTalking = false;
            footsteps.enabled = true;
            //pc.freezeMovement = false;
        }
    }




    IEnumerator ContinueDialogue()
    {
        yield return new WaitForSeconds(3f);
        dialogue1.SetActive(false);
        dialogue2.SetActive(true);
        dialogueImage.enabled = (true);
        yield return new WaitForSeconds(2f);
        isTalking = false;
        footsteps.enabled = true;
        dialogue2.SetActive(false);
        dialogueImage.enabled = (false);
    }

    IEnumerator thirdDialogue()
    {
        dialogue3.SetActive(true);
        box2.SetActive(true);
        dialogueImage.enabled = (true);
        third = true;
        yield return new WaitForSeconds(4f);
        dialogue3.SetActive(false);
        dialogueImage.enabled = (false);
    }

}
