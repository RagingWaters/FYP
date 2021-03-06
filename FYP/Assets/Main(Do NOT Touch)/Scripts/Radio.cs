﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
    public AudioClip sound;
    public float volume;
    public AudioSource audioSource;
    public bool alreadyPlayed = false;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !alreadyPlayed)
        {
            audioSource.Play();
            alreadyPlayed = true;

        }
        else
        {
            //audioSource.Pause();
        }
    }
}
