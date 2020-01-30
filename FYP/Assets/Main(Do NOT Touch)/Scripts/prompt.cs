using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class prompt : MonoBehaviour
{

    //public GameObject promptopt;
    
    public Image pickupIcon;

    // Start is called before the first frame update
    void Start()
    {
        //promptopt.SetActive(false);
        pickupIcon.enabled = (false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //promptopt.SetActive(true);
            pickupIcon.enabled = (true);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Input.GetKeyDown(KeyCode.Space) || other.tag == "Player" && Input.GetButtonDown("Interact"))
        {
            //promptopt.SetActive(false);
            pickupIcon.enabled = (false);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //promptopt.SetActive(false);
            pickupIcon.enabled = (false);
        }
    }
}
