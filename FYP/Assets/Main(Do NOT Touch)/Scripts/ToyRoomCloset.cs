using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToyRoomCloset : MonoBehaviour
{
    public Toy t;

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
            t.volume = 0;
            t.audioSource.Stop();
        }
    }
}
