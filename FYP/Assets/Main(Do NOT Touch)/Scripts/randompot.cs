using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randompot : MonoBehaviour
{
    public GameObject randomshovelopt;
    public PlayerControls Player;
    public GameObject warning;
    public GameObject foundcig;

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
                randomshovelopt.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            randomshovelopt.SetActive(false);
            warning.SetActive(false);
            foundcig.SetActive(false);
        }
    }
}