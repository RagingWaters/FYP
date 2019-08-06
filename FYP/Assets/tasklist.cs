using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tasklist : MonoBehaviour
{

    public GameObject Tasklist;

    public LevelManager theLevelManager;

    public int current;

    // Start is called before the first frame update
    void Start()
    {
        theLevelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void tasklists()
    {
        Tasklist.SetActive(true);
    }

    public void backz()
    {
        Tasklist.SetActive(false);
    }

}
