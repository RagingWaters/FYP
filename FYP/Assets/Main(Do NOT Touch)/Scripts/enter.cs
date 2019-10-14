using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enter : MonoBehaviour
{
    public GameObject Level1Spawner1;
    public GameObject Level1Spawner2;
    public int setLevel,setMax;

    public AudioClip soundtoPlay;
    public float volume;
   // AudioSource audio;
    public bool alreadyPlayed = false;


    void Start()
    {
   //     audio = GetComponent<AudioSource>();
    }


   void OnTriggerEnter()

    {
        enemySpawner.currentLevel = setLevel;
        enemySpawner.maxLevel = setMax;
        enemySpawner.startSpawn = true;
        Level1Spawner1.SetActive(true);
        Level1Spawner2.SetActive(true);

      // if (!alreadyPlayed)
       // {
        //    audio.PlayOneShot(soundtoPlay, volume);
        //   alreadyPlayed = true;
       // }
    }
}
