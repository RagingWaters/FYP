using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{

    public LevelManager theLevelManager;
    public int keyValue;
    public GameObject keyy;
    //public GameObject dialogue;

    // Start is called before the first frame update
    void Start()
    {
        theLevelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                theLevelManager.AddKey(keyValue);
                print("added key");
                Destroy(gameObject);
                keyy.SetActive(false);
                //dialogue.SetActive(true);
            }
        }
    }
    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.gameObject.tag == "Player")
    //    {
    //        dialogue.SetActive(false);
    //    }
    //}
}