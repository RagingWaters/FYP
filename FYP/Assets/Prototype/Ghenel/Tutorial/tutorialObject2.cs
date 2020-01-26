using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialObject2 : MonoBehaviour
{
    public tutorialwin tw;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "2")
        {
            tw.Correct2 = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "2")
        {
            tw.Correct2 = false;
        }
    }
}
