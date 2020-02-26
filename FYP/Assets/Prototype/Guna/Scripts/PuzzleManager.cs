using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public bool Correct1 = false;
    public bool Correct2 = false;
    public bool Correct3 = false;
    public bool Correct4 = false;
    public bool winner = false;
    LevelManager lm;

    // Start is called before the first frame update
    void Start()
    {
        //lm = LevelManager.instance;
        lm = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Correct1 == true)
        {
            print("1");
        }

        if(Correct2 == true)
        {
            print("2");
        }

        if (Correct3 == true)
        {
            print("3");
        }

        if (Correct1 == true && Correct2 == true && Correct3 == true && Correct4 == true && winner == false)
        {
            lm.Win();
            print("Ez game boys");
        }
    }
}
