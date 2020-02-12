using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scarezoom : MonoBehaviour
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
            anim.Play("zoomscare");
            audioSource.Play();
            alreadyPlayed = true;
            StartCoroutine(StopDialogue());
        }
    }

    IEnumerator StopDialogue()
    {
        yield return new WaitForSeconds(1f);
        enemy.SetActive(false);
    }
}