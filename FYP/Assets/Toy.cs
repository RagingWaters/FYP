using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toy : MonoBehaviour
{

    public GameObject Activation;
    public GameObject toytoDestroy;
    public AudioSource audioSource;
    public AudioClip wakeUp;
    public LevelManager lm;
    public GameObject originalSpawn;
    public Transform newSpawnEnemy;
    public float volume;
    protected bool letPlay = true;
    [SerializeField] public int ToyActive;

    // Start is called before the first frame update
    void Start()
    {
        ToyActive = 0;
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
        if (other.gameObject.tag == "Player" && ToyActive == 0)
        {
            Debug.Log("Toy Activated");
            ToyActive = 1;
            originalSpawn.transform.position = newSpawnEnemy.position;
            StartCoroutine(ActivatedToy());  
        }

        if (other.gameObject.tag == "Player" && ToyActive == 1 && Input.GetKeyDown(KeyCode.Space))
        {
            lm.currentClock = 1;
            Destroy(toytoDestroy);
            Destroy(Activation);
        }
    }

    IEnumerator ActivatedToy()
    {
        Activation.SetActive(true);
        audioSource.PlayOneShot(wakeUp, volume);
        enemySpawner.startSpawn = true;
        yield return new WaitForSeconds(4f);
        Activation.SetActive(false);
    }
}
