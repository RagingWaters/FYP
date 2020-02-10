using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scare1 : MonoBehaviour
{

    public GameObject enemy;

    public Animator anim;

    public AudioSource audioSource;

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
        if (other.gameObject.tag == "Player")
        {
            enemy.SetActive(true);
            anim.Play("scare1");
            audioSource.Play();
            StartCoroutine(StopDialogue());
        }
    }

    IEnumerator StopDialogue()
    {
        yield return new WaitForSeconds(1f);
        enemy.SetActive(false);

    }

}
