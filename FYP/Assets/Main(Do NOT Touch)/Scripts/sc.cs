using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc : MonoBehaviour
{

    public LevelManager theLevelManager;
   

    // Start is called before the first frame update
    void Start()
    {
        theLevelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        theLevelManager.blocker1();
        theLevelManager.blocker2();
        theLevelManager.blocker3();
    }
}
