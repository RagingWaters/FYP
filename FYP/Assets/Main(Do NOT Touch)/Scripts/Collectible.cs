﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectible : MonoBehaviour
{    
    public GameObject newspaperText;
    private Animation anim;
    public static int theScore;
    bool collected;
   
    //DestroyObject d;

    public void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.Space) && other.tag == "Player" && !collected)
        {       
     
            StartCoroutine(TextAnimation());
            Debug.Log("Hi2");        
            Debug.Log(theScore);
            GetComponent<MeshRenderer>().enabled = false;
        }
    }

    IEnumerator TextAnimation()
    {
        collected = true;
        newspaperText.SetActive(true);
        anim = newspaperText.GetComponent<Animation>();
        theScore++;
        newspaperText.GetComponent<Text>().text = "Pieces : " + theScore + " / 4";
        yield return new WaitUntil(() => !anim.isPlaying);
        Debug.Log("Hi");
        newspaperText.SetActive(false);

        Destroy(gameObject);
    }

    



}
