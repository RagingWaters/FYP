using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    
    public void destroyObject()
    {
        Destroy(this);
    }
    /*
    public void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.Space) && other.tag == "Player")
        {            
            theScore += 1;
            newspaperText.GetComponent<Text>().text = "Pieces : " + theScore + " / 4";

            Debug.Log("Hi2");

            destroyObject();
            Debug.Log(theScore);
        }
    }

    */






}
