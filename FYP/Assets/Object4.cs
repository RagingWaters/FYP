using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object4 : MonoBehaviour
{
    public PuzzleManager pm;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "4")
        {
            pm.Correct4 = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "4")
        {
            pm.Correct4 = false;
        }
    }


}