using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cross : MonoBehaviour
{

    public LevelManager theLevelManager;
    public int crossValue;

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
                theLevelManager.AddCross(crossValue);
                print("added cross");
                Destroy(gameObject);
            }
        }
    }
}
