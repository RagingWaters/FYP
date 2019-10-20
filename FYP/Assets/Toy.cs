using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toy : MonoBehaviour
{

    public GameObject Activation;
    //public AudioClip otherClip;
    protected bool letPlay = true;

    // Start is called before the first frame update
    void Start()
    {
        //AudioSource audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (letPlay)
        {
            if (!Activation.isPlaying)
            {
                Activation.Play();
            }
        }
        else
        {
            if (Activation.isPlaying)
            {
                Activation.Stop();
            }
        }*/

    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" /*&& Input.GetKeyDown(KeyCode.K)*/)
        {
            Debug.Log("Toy Activated");
            //letPlay = !letPlay;
            Activation.SetActive(true);
            enemySpawner.startSpawn = true;
            //audio.Play();
            StartCoroutine(ActivatedToy());
            
        }

    }

    IEnumerator ActivatedToy()
    {
        yield return new WaitForSeconds(10f);
        Activation.SetActive(false);
        //Destroy(this.gameObject);
    }
}
