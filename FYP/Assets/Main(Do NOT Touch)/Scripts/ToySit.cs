using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToySit : MonoBehaviour
{
    public LevelManager lm;
    public int toyValue;
    public enemySpawner es;
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
                
                lm.AddClock(toyValue);
                print("added Clock, spawning ghost");
                Destroy(gameObject);
               
                enemySpawner.startSpawn = true;
            }
        }
    }
}
