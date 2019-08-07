using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastdoor : MonoBehaviour
{

    public GameObject lastdooropt;
    public PlayerControls Player;
    public GameObject warning;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                lastdooropt.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            lastdooropt.SetActive(false);
            warning.SetActive(false);
        }
    }
}
