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
    public GameObject dig;

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
        shovelopt.SetActive(true);

        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.Space) || other.gameObject.tag == "Player" && Input.GetButtonDown("Interact"))
        {
            if (lm.currentShovel == 1)
            {
                lm.keyy.SetActive(true);
                dig.SetActive(false);
                warning.SetActive(false);
                foundkey.SetActive(true);
                lm.keypotopt.SetActive(true);

            }
            else if (lm.currentShovel == 0)
            {
                warning.SetActive(true);
                dig.SetActive(false);
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
