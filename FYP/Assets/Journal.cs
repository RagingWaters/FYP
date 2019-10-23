using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Journal : MonoBehaviour
{
    public LevelManager lm;
    public int journalValue;
    
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
                print("added journal, spawning ghost");
                Destroy(gameObject);
            }
        }
    }
}
