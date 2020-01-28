using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class prompt : MonoBehaviour
{

    public GameObject promptopt;
    
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
            promptopt.SetActive(true);
            pickupIcon.enabled = (true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            promptopt.SetActive(false);
            pickupIcon.enabled = (false);
        }
    }
}
