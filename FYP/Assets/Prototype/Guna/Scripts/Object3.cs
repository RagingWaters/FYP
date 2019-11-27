using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object3 : MonoBehaviour
{
    public PuzzleManager pm;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "3")
        {
            pm.Correct3 = true;
        }

        if (other.tag != "3")
        {
            pm.Correct3 = false;
        }
    }
}
