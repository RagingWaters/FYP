using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulsetrigger : MonoBehaviour
{
    public GameObject box1;
    public GameObject box2;
    //public Animator anim;
    // Start is called before the first frame update
    public Light myLight;
    public Light myLight1;
    public float maxIntensity = 0.7f;
    public float minIntensity = 0f;
    public float pulseSpeed = 0.5f; //here, a value of 0.5f would take 2 seconds and a value of 2f would take half a second
    private float targetIntensity = 1f;
    private float currentIntensity;

    void Start()
    {
        box1.SetActive(false);
        box2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        currentIntensity = Mathf.MoveTowards(myLight.intensity, targetIntensity, Time.deltaTime * pulseSpeed);
        if (currentIntensity >= maxIntensity)
        {
            currentIntensity = maxIntensity;
            targetIntensity = minIntensity;
        }
        else if (currentIntensity <= minIntensity)
        {
            currentIntensity = minIntensity;
            targetIntensity = maxIntensity;
        }
        myLight.intensity = currentIntensity;

        currentIntensity = Mathf.MoveTowards(myLight1.intensity, targetIntensity, Time.deltaTime * pulseSpeed);
        if (currentIntensity >= maxIntensity)
        {
            currentIntensity = maxIntensity;
            targetIntensity = minIntensity;
        }
        else if (currentIntensity <= minIntensity)
        {
            currentIntensity = minIntensity;
            targetIntensity = maxIntensity;
        }
        myLight1.intensity = currentIntensity;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(waitpulse());

            StartCoroutine(waitpulse2());
        }
    }

    IEnumerator waitpulse()
    {
        yield return new WaitForSeconds(15f);
        box1.SetActive(true);
    }

    IEnumerator waitpulse2()
    {
        yield return new WaitForSeconds(25f);
        box2.SetActive(true);
    }
}