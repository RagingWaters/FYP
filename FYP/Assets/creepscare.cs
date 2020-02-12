using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creepscare : MonoBehaviour
{
    public GameObject enemy;
    public Animator anim;
    public AudioSource audioSource;
    public bool alreadyPlayed = false;

    // Start is called before the first frame update
    void Start()
    {
        enemy.SetActive(false);
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
            StartCoroutine(waitforit());

        }
    }

    IEnumerator waitforit()
    {
        yield return new WaitForSeconds(4f);
        anim.Play("creep");
            audioSource.Play();
            alreadyPlayed = true;
            StartCoroutine(StopDialogue());
    }

    IEnumerator StopDialogue()
    {
        yield return new WaitForSeconds(1f);
        enemy.SetActive(false);
    }
}