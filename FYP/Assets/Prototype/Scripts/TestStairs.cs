using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestStairs : MonoBehaviour
{

    public GameObject player;
    public Transform Target;

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
    }

    void Teleport()
    {
        player.transform.position = Target.transform.position;
    }
}
