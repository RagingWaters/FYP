using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object3 : MonoBehaviour
{
    public PuzzleManager pm;
    public NormalPuzzleWin nw;

    //void OnTriggerStay(Collider other)
    //{
    //    if (other.tag == "3")
    //    {
    //        pm.Correct3 = true;
    //        nw.Correct3 = true;
    //    }
    //}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "3")
        {
            //pm.Correct3 = true;
            nw.Correct3 = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "3")
        {
            pm.Correct3 = false;
        }
    }

    
}
