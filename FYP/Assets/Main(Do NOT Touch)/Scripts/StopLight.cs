using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopLight : MonoBehaviour
{
    public LightAdjuster lightAdjust;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        lightAdjust.MinusRange();
    }
}
