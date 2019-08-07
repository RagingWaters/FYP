using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FallSound : MonoBehaviour
    
{
   
    public AudioClip sound;
    public float volume;
    AudioSource source;
    public bool alreadyPlayed = false;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void OnTriggerEnter()
    {
        if (!alreadyPlayed)
        {
            source.PlayOneShot(sound, volume);
            alreadyPlayed = true;
        }
    }
}
