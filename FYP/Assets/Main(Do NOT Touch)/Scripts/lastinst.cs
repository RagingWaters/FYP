using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastinst : MonoBehaviour
{
    public GameObject inst1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            inst1.SetActive(false);
        }
    }
}
