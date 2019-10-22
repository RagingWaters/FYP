using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour
{
    LevelManager lm;
    public GameObject hide;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            enemySpawner.startSpawn = false;
            Debug.Log("ghost dieded");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            hide.SetActive(true);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        hide.SetActive(false);
    }
}
