using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuyChar : MonoBehaviour
{
    Animator guyAnim;
    public GameObject guyScare1;
    public 


    // Start is called before the first frame update
    void Start()
    {
        guyAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if ( )
            guyScare1.SetActive(true);
            */
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            guyScare1.SetActive(true);
        }
    }





}
