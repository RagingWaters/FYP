using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torchlight : MonoBehaviour
{

    public LevelManager theLevelManager;
    public int torchValue;

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
                theLevelManager.AddTorch(torchValue);
                print("added torch, spawning ghost");
                Destroy(gameObject);
            }
        }
    }
}