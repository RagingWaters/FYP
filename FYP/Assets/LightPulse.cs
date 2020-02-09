using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPulse : MonoBehaviour
{
    public Light myLight;
    public float maxIntensity = 0.8f;
    public float minIntensity = 0f;
    public float pulseSpeed = 0.4f; //here, a value of 0.5f would take 2 seconds and a value of 2f would take half a second
    public float targetIntensity = 1f;
    public float currentIntensity;


    void Start()
    {

    }
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
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
            }
        }
    }
}
