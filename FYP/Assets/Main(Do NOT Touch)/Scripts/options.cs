using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class options : MonoBehaviour
{

    public GameObject light;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void protection()
    {
        Destroy(GameObject.FindWithTag("Enemy"));
    }

    public void clue1()
    {
        light.SetActive(true);
    }
}
