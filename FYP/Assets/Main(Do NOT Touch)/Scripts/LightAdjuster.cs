using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightAdjuster : MonoBehaviour
{
    public Light myLight;
    // Range Variables

    public bool changeRange = false;
    public float rangeSpeed = 1.0f;
    public float maxRange = 10.0f;
    public bool repeatRange = false;

    // Intensity Variables

    public bool changeIntensity = false;
    public float intensitySpeed = 1.0f;
    public float maxIntensity = 10.0f;
    public bool repeatIntensity = false;

    //Color Variables

    public bool changeColors = false;
    public float colorSpeed = 1.0f;
    public Color startColor;
    public Color endColor;
    public bool repeatColor = false;

    float startTime;
    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
       
        
        if (changeColors)
        {
            float t = (Mathf.Sin(Time.time - startTime * colorSpeed));
            myLight.color = Color.Lerp(startColor, endColor, t); 
        }
    }
    public void Range()
    {
        if (changeRange)
        {
            myLight.range = rangeSpeed += 4.0f;
            if (myLight.range >= maxRange)
            {
                changeRange = false;
            }





        }
    }
    public void Intensity()
    {
        if (changeIntensity)
        {
            myLight.intensity = intensitySpeed += 4.0f;
            if (myLight.intensity >= maxIntensity)
            {
                changeIntensity = false;
            }





        }
    }

}
