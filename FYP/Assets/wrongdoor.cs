using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wrongdoor : MonoBehaviour
{

    public GameObject wrongdooropt;
    public PlayerControls Player;
    
    //public GameObject warning;
    //public GameObject warning1;

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
            wrongdooropt.SetActive(true);
           
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            wrongdooropt.SetActive(false);
            
            //warning.SetActive(false);
            //warning1.SetActive(false);
        }
    }
}
