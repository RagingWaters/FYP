using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopClock : MonoBehaviour
{
    //public AudioSource audioSource;
    public GameObject alarmClock;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //audioSource.Pause();
            Debug.Log("clockstop");
            Destroy(alarmClock);
        }
    }
}
