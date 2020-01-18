using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FadeTransition : MonoBehaviour
{
    public Image imageToFade;
    public GameObject fadeImage;

    // Start is called before the first frame update
    void Start()
    {
        Fade();       
    }
    
    void Fade()
    {
        fadeImage.SetActive(true);
        imageToFade.color = Color.black;
        imageToFade.CrossFadeAlpha(0, 1.2f, false);
        StartCoroutine(OffFade());
    }

    IEnumerator OffFade()
    {
        yield return new WaitForSeconds(1.5f);

        fadeImage.SetActive(false);
    }
}
