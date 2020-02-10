using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testguychar : MonoBehaviour
{

    public GameObject guyChar;

    ScareManagement sm;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            
        }
            

    }


    // Start is called before the first frame update
    void Start()
    {
        sm = GetComponent<ScareManagement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
