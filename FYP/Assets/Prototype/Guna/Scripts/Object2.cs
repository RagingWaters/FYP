﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object2 : MonoBehaviour
{
    public PuzzleManager pm;
    public NormalPuzzleWin nw;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "2")
        {
            pm.Correct2 = true;
            nw.Correct2 = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "2")
        {
            pm.Correct2 = false;
        }
    }
}
