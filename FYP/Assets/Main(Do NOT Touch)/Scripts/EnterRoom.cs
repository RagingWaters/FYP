﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterRoom : MonoBehaviour
{
    public GameObject Activecam;
    public GameObject DisableCam;

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
        if (other.gameObject.tag == "Player")
        {
            print("HitPlyer");
            Activecam.SetActive(true);
            DisableCam.SetActive(false);
            // StartCoroutine(BigBoy());  
        }
    }

    //IEnumerator BigBoy()
    //{
    //    yield return new WaitForSeconds(1f);
    //    mainCam.SetActive(false);
    //}
}
