using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Journal : MonoBehaviour
{
    public LevelManager lm;
    public int journalValue;
    //public GameObject dialogue;
    //public GameObject dgameObject;
    // Start is called before the first frame update
    void Start()
    {
        lm = FindObjectOfType<LevelManager>();
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
              
                lm.AddJournal(journalValue);
                //dialogue.SetActive(true);
                //dgameObject.SetActive(true);
                print("added journal");
                Destroy(gameObject);
            }
        }
    }
}
