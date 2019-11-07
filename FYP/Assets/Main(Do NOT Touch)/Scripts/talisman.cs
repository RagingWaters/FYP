using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talisman : MonoBehaviour
{

    public LevelManager theLevelManager;
    public int talismanValue;
    public GameObject winscreen;


    // Start is called before the first frame update
    void Start()
    {
        theLevelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                theLevelManager.AddTalisman(talismanValue);
                print("added Talisman");
                winscreen.SetActive(true);
                Destroy(gameObject);
            }
        }
    }
}