using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keypot : MonoBehaviour
{

    public GameObject shovelopt;
    public PlayerControls Player;
    public GameObject warning;
    public GameObject foundkey;

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
                shovelopt.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            shovelopt.SetActive(false);
            warning.SetActive(false);
            foundkey.SetActive(false);
        }
    }
}