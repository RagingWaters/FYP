using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialObject1 : MonoBehaviour
{
    public tutorialwin tw;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "1")
        {
            tw.Correct1 = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "1")
        {
            tw.Correct1 = false;
        }
    }
}
