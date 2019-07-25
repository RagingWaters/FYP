using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altar : MonoBehaviour
{

    public GameObject options;
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
                options.SetActive(true);
            }
        }
    }
    

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            options.SetActive(false);
        }
    }
}
