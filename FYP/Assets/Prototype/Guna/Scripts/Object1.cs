using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object1 : MonoBehaviour
{
    public PuzzleManager pm;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "1")
        {
            pm.Correct1 = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "1")
        {
            pm.Correct1 = false;
        }
    }
}
