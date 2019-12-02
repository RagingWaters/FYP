using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalObject2 : MonoBehaviour
{
    public NormalPuzzleWin nw;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "2")
        {
            nw.Correct2 = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "2")
        {
            nw.Correct2 = false;
        }
    }
}
