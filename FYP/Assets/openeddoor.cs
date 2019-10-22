using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openeddoor : MonoBehaviour
{

    public GameObject openedooropt;
    public PlayerControls Player;
    public GameObject disableDoor;

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
        if (other.gameObject.tag == "Player")
        {
            openedooropt.SetActive(true);
            if (Input.GetKeyDown(KeyCode.P))
            {
                disableDoor.SetActive(false);
                openedooropt.SetActive(false);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            openedooropt.SetActive(false);
        }
    }
}