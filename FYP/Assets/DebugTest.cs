using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTest : MonoBehaviour
{
    LevelManager lm;
    PrologueManager pm;

    // Start is called before the first frame update
    void Start()
    {
        lm = FindObjectOfType<LevelManager>();
        pm = FindObjectOfType<PrologueManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            lm.Win();
            pm.prelogueManager.SetActive(false);
            Debug.Log("win");
        }                    
    }
}

