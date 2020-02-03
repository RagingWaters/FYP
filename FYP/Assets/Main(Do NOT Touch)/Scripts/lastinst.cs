using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastinst : MonoBehaviour
{
    public GameObject inst1;

    PlayerControls pc;

    public static bool instructionIsActive = true;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Interact") && instructionIsActive == true)
        {
            inst1.SetActive(false);        
            instructionIsActive = false;
        }
    }
}
