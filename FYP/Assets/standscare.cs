using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class standscare : MonoBehaviour
{
    public GameObject enemy;
    public GameObject lighty;
    public Animator anim;
    public AudioSource audioSource;
    public bool alreadyPlayed = false;

    // Start is called before the first frame update
    void Start()
    {
        enemy.SetActive(false);
        lighty.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !alreadyPlayed)
        {
            enemy.SetActive(true);
            lighty.SetActive(true);
            anim.Play("standscare");
            audioSource.Play();
            alreadyPlayed = true;
            StartCoroutine(StopDialogue());
        }
    }

    IEnumerator StopDialogue()
    {
        yield return new WaitForSeconds(4f);
        enemy.SetActive(false);
        lighty.SetActive(false);
    }
}