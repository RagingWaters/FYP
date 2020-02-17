using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shovel : MonoBehaviour
{

    public LevelManager theLevelManager;
    public int shovelValue;

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
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Interact"))
            {
                theLevelManager.AddShovel(shovelValue);
                print("added shovel");
                Destroy(gameObject);
            }
        }
    }
}