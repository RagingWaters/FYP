using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emptypot : MonoBehaviour
{

    public GameObject emptyshovelopt;
    public PlayerControls Player;
    public GameObject warning;
    public LevelManager lm;
    public GameObject NTH;
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
        emptyshovelopt.SetActive(true);

        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.Space))
        {
            if (lm.currentShovel == 1)
            {
                dig.SetActive(false);
                 warning.SetActive(false);
                NTH.SetActive(true);
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
            emptyshovelopt.SetActive(false);
            warning.SetActive(false);
            NTH.SetActive(false);
        }
    }
}