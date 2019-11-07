using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleDoor : MonoBehaviour
{
    public GameObject opendoorOpt;
    public PlayerControls pc;
    public Animator anim;
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
        if (other.gameObject.tag == "Player")
        {
            opendoorOpt.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                anim.Play("PuzzleDoorOpen");
                Debug.Log("dooropen");
                //disableDoor.SetActive(false);
                opendoorOpt.SetActive(false);

            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            opendoorOpt.SetActive(false);
        }
    }
}
