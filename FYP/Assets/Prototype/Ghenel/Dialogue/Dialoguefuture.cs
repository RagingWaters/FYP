using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialoguefuture : MonoBehaviour
{
    public GameObject dialogue1;
    public GameObject dialogue2;
    //public DialogueManager theDialogueManager;
    public static bool isTalking;
    PlayerControls pc;
    public GameObject player;
    public Transform Target;
    private bool cd;


    void Start()
    {
        cd = false;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && isTalking == false)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Interact"))
            {
                //pc.freezeMovement = true;
                isTalking = true;
                dialogue1.SetActive(true);
                StartCoroutine(ContinueDialogue());

                //if (Input.GetKeyDown(KeyCode.Space) && isTalking == false || Input.GetButtonDown("Interact") && isTalking == false)
                //{
                //    dialogue1.SetActive(false);
                //    dialogue2.SetActive(true);
                //    isTalking = true;
                //}
            }

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //dialogue1.SetActive(false);
            dialogue2.SetActive(false);
            isTalking = false;
            //pc.freezeMovement = false;
        }
    }

    IEnumerator ContinueDialogue()
    {
        yield return new WaitForSeconds(7f);
        dialogue1.SetActive(false);
        dialogue2.SetActive(true);
        yield return new WaitForSeconds(4f);
        isTalking = false;
        dialogue2.SetActive(false);
        cd = true;
        StartCoroutine(Teleport());
    }

    IEnumerator Teleport()
    {
        player.transform.position = Target.transform.position;
        yield return new WaitForSeconds(2f);
        cd = false;
    }

    /*public void Next()
    {
        dialogue1.SetActive(false);
        dialogue2.SetActive(true);
        
    }*/
    //void Start()
    //{
    //    //theDialogueManager = FindObjectOfType<DialogueManager>();
    //}
    //void OnTriggerStay(Collider other)
    //{
    //    if (other.gameObject.tag == "Player")
    //    {
    //        if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Interact"))
    //        {
    //            theDialogueManager.StartDialogue(dialogue);
    //        }
    //    }
    //}
}