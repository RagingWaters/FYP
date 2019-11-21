using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openeddoor : MonoBehaviour
{

    public GameObject openedooropt;
    public PlayerControls Player;
   // public GameObject disableDoor;
    public Animator anim;
    public GameObject open;
    public bool opendoor = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider other)
    {
        if(opendoor == false)
        {
            openedooropt.SetActive(true);
            if (other.gameObject.tag == "Player")
            {
                //openedooropt.SetActive(true);
                if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Interact"))
                {
                    anim.Play("GateDoorOpen");
                    Debug.Log("dooropen");
                    //disableDoor.SetActive(false);

                    openedooropt.SetActive(false);
                    open.SetActive(false);
                    opendoor = true;
                }
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