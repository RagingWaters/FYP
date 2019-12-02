using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalObject1 : MonoBehaviour
{
    public NormalPuzzleWin nw;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "1")
        {
            nw.Correct1 = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "1")
        {
            nw.Correct1 = false;
        }
    }
}
