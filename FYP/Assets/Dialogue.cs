using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public GameObject dialogue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            dialogue.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        dialogue.SetActive(false);
        Destroy(gameObject);
    }
}
