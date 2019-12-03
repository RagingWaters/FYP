using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc1flashback : MonoBehaviour
{

    public GameObject npc1fb;

    // Start is called before the first frame update
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Interact"))
            {
                npc1fb.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            npc1fb.SetActive(false);
        }
    }
}
