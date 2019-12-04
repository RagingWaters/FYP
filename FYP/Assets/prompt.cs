using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prompt : MonoBehaviour
{

    public GameObject promptopt;

    // Start is called before the first frame update
    void Start()
    {
        promptopt.SetActive(false);
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
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            promptopt.SetActive(false);
        }
    }
}
