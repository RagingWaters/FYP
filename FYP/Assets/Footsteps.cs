using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    PlayerControls pc;
    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        pc = GetComponent<PlayerControls>();
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pc.isMoving == true && source.isPlaying == false)
        {
            source.Play();
        }
    }
}
