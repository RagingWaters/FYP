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

        if (other.tag != "1")
        {
            pm.Correct1 = false;
        }
    }
}
