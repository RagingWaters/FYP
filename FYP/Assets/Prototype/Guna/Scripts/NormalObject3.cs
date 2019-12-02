using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalObject3 : MonoBehaviour
{
    public NormalPuzzleWin nw;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "3")
        {
            nw.Correct3 = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "3")
        {
            nw.Correct3 = false;
        }
    }
}
