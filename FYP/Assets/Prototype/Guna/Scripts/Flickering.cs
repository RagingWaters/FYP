using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flickering : MonoBehaviour
{
    [Range(0,5)]
    public float flickerInterval;
    Light flashingLight;

    // Start is called before the first frame update
    void Start()
    {
        flashingLight = GetComponent<Light>();
        StartCoroutine(Flashing());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Flashing()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(0, flickerInterval));
            flashingLight.enabled = !flashingLight.enabled;
        }
    }
}
