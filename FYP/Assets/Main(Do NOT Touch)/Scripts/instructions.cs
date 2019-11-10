using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instructions : MonoBehaviour
{
    public GameObject inst1;
    public GameObject inst2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Interact"))
        {
            inst1.SetActive(false);
            inst2.SetActive(true);
        }
    }
}
