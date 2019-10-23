using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Journal : MonoBehaviour
{
    public LevelManager lm;
    public int journalValue;
    public GameObject currentSpawner1;
    public GameObject currentSpawner2;
    public GameObject currentSpawner3;
    public GameObject currentSpawner4;
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
                currentSpawner1.SetActive(false);
                currentSpawner2.SetActive(false);
                currentSpawner3.SetActive(true);
                currentSpawner4.SetActive(true);
                lm.AddJournal(journalValue);
                print("added journal, spawning ghost");
                Destroy(gameObject);
            }
        }
    }
}
