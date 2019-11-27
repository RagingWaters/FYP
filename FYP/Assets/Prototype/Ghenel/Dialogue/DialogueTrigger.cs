using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject dialogue1;
    public GameObject dialogue2;
    //public DialogueManager theDialogueManager;

    public void TriggerDialogue()
    {

    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Interact"))
            {
                dialogue1.SetActive(true);

            }
        
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //dialogue1.SetActive(false);
            dialogue2.SetActive(false);
        }
    }

    public void Next()
    {
        dialogue1.SetActive(false);
        dialogue2.SetActive(true);
        
    }
    //void Start()
    //{
    //    theDialogueManager = FindObjectOfType<DialogueManager>();
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
