using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioSource aSource;
    public float volume;
    public AudioClip aClip;
    public AudioClip bClip;
    public AudioClip cClip;

    // Start is called before the first frame update
    void Start()
    {
        aSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Door()
    {
        aSource.PlayOneShot(aClip, volume);
    }
    public void Pickup()
    {
        aSource.PlayOneShot(bClip, volume);
    }

    public void Box()
    {
        aSource.PlayOneShot(cClip, volume);
    }
}
