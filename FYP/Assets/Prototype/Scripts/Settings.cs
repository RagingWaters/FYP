using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{
    private AudioSource audiSource;
    private float musicVol = 1f;
    // Start is called before the first frame update

    private void Start()
    {
        audiSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        audiSource.volume = musicVol;
    }
    public void SetVolume(float volume)

    {
        musicVol = volume;
        Debug.Log(volume);
    }
}
