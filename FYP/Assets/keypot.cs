using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keypot : MonoBehaviour
{

    public GameObject shovelopt;
    public PlayerControls Player;
    public GameObject warning;
    public GameObject foundkey;
    public LevelManager lm;

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
            shovelopt.SetActive(true);
            if (lm.currentShovel == 1 && Input.GetKeyDown(KeyCode.Space))
            {
                shovelopt.SetActive(false);
                foundkey.SetActive(true);
                lm.keypotopt.SetActive(true);
                lm.keyy.SetActive(true);
            }
            else if(lm.currentShovel == 0)
            {
                lm.warning0shovel.SetActive(true);
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