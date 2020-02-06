using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject dialogue1;
    public GameObject dialogue2;
    public GameObject dialogue3;

    public Image dialogueImage;

    //public DialogueManager theDialogueManager;
    public static bool isTalking;
    PlayerControls pc;
    public Radio radio;
    /*
    private void Start()
    {
        dialogueImage.enabled = (false);
    }
    */
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && isTalking == false)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Interact"))
            {
                //pc.freezeMovement = true;
                isTalking = true;
                dialogue1.SetActive(true);
                dialogueImage.enabled = (true);
                StartCoroutine(ContinueDialogue());
                radio.audioSource.Pause();
                Debug.Log("paused");
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
            dialogueImage.enabled = (false);
            isTalking = false;
            //pc.freezeMovement = false;
}
    }

    IEnumerator ContinueDialogue()
    {
        yield return new WaitForSeconds(7f);
        dialogue1.SetActive(false);
        dialogue2.SetActive(true);
        dialogueImage.enabled = (true);
        yield return new WaitForSeconds(4f);
        dialogue2.SetActive(false);
        dialogue3.SetActive(true);
        yield return new WaitForSeconds(4f);
        dialogue3.SetActive(false);
        dialogueImage.enabled = (false);
        isTalking = false;
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
