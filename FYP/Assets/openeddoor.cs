using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openeddoor : MonoBehaviour
{

    public GameObject openedooropt;
    public PlayerControls Player;

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
            if (Input.GetKeyDown(KeyCode.K))
            {
                openedooropt.SetActive(true);
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