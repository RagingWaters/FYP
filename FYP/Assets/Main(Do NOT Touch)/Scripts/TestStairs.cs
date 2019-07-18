using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestStairs : MonoBehaviour
{

    public GameObject player;
    public Transform Target;
    public Transform Target2;

    void Start()
    {
        player = FindObjectOfType<PlayerControls>().gameObject;
    }

    void Teleport()
    {
        player.transform.position = Target.transform.position;
    }

    void Teleport2()
    {
        player.transform.position = Target2.transform.position;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Teleport();
            }

            else if (Input.GetKeyDown(KeyCode.F))
            {
                Teleport2();
            }
        }
    }
}
