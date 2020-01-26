using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorial : MonoBehaviour
{
    public GameObject dialogue1;
    public GameObject dialogue2;
    public GameObject key1;
    public GameObject key2;
    public GameObject key3;
    public GameObject box1;
    public GameObject box2;



    public Image dialogueImage;

    //public DialogueManager theDialogueManager;
    public static bool isTalking;
    PlayerControls pc;

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && isTalking == false)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Interact"))
            {
                //pc.freezeMovement = true;
                isTalking = true;
                dialogue1.SetActive(true);
                key1.SetActive(true);
                key2.SetActive(true);
                key3.SetActive(true);
                box1.SetActive(true);
                dialogueImage.enabled = (true);
                StartCoroutine(ContinueDialogue());

                Debug.Log("paused");
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
        yield return new WaitForSeconds(5f);
        dialogue1.SetActive(false);
        dialogue2.SetActive(true);
        dialogueImage.enabled = (true);
        yield return new WaitForSeconds(4f);
        isTalking = false;
        dialogue2.SetActive(false);
        dialogueImage.enabled = (false);
    }

}
