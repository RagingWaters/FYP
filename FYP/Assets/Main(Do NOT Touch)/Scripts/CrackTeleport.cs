using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrackTeleport : MonoBehaviour
{

    public GameObject player;
    public Transform Target;
    public GameObject sepiaFilter;
    


    public Image imageToFade;
    public GameObject fadeImage;

    void Start()
    {
    }


    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.Space)  || Input.GetButtonDown("Interact") )
            {
                StartCoroutine(Teleport());
            }
        }
    }

    void Fade()
    {
        fadeImage.SetActive(true);
        imageToFade.color = Color.black;
        imageToFade.CrossFadeAlpha(0, 1.2f, false);
        StartCoroutine(OffFade());
    }

    IEnumerator Teleport()
    {
        Fade();
        player.transform.position = Target.transform.position;
        yield return new WaitForSeconds(1f);
        sepiaFilter.SetActive(true);
        yield return new WaitForSeconds(2f);
       
    }

    IEnumerator OffFade()
    {
        yield return new WaitForSeconds(1.5f);

        fadeImage.SetActive(false);
    }
}
