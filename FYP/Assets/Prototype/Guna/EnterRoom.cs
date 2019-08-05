﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterRoom : MonoBehaviour
{
    public GameObject cam;
    public GameObject mainCam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            cam.SetActive(true);
            StartCoroutine(BigBoy());  
        }
    }

    IEnumerator BigBoy()
    {
        yield return new WaitForSeconds(0.5f);
        mainCam.SetActive(false);
    }
}
