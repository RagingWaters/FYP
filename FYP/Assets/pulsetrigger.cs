using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulsetrigger : MonoBehaviour
{
    public GameObject box1;
    public GameObject box2;
    public GameObject box3;
    //public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        box1.SetActive(false);
        box2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(waitpulse());

            StartCoroutine(waitpulse2());

            StartCoroutine(waitpulse3());
        }
    }

    IEnumerator waitpulse()
    {
        yield return new WaitForSeconds(5f);
        box1.SetActive(true);
    }

    IEnumerator waitpulse2()
    {
        yield return new WaitForSeconds(10f);
        box2.SetActive(true);

    }

     IEnumerator waitpulse3()
        {
            yield return new WaitForSeconds(15f);
        box3.SetActive(true);
        }
}