using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public GameObject winscreen;
    private static int Current;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Current = Collectible.theScore;
        if (Current >= 4)
        {
            Win();
        }
    }

    void Win()
    {
        winscreen.SetActive(true);
    }
}
