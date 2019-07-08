using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestStairs : MonoBehaviour
{

    public GameObject player;
    public Transform Target;
    public Transform Target2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerStay(Collider other)
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Teleport();
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            Teleport2();
        }
    }

    void Teleport()
    {
        player.transform.position = Target.transform.position;
    }

    void Teleport2()
    {
        player.transform.position = Target2.transform.position;
    }
}
