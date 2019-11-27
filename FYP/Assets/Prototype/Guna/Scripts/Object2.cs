﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object2 : MonoBehaviour
{
    public PuzzleManager pm;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "2")
        {
            pm.Correct2 = true;
        }

        if (other.tag != "2")
        {
            pm.Correct2 = false;
        }
    }
}
