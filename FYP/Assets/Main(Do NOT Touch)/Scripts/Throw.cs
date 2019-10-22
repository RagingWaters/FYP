using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    public Transform player;
    public float throwForce = 10f;
    bool hasPlayer = false;
    bool beingCarried = false;
    private bool touched = false;
    //public GameObject winscreen;
    [SerializeField] Rigidbody rb;
    public PlayerControls pc;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, player.position);
        if (dist <= 250f)
        {
            hasPlayer = true;
            Debug.Log("in range");
            /*rb.constraints = RigidbodyConstraints.FreezePositionX;
            rb.constraints = RigidbodyConstraints.FreezePositionZ;*/
        }
        else
        {
            hasPlayer = false;
            rb.constraints = RigidbodyConstraints.None;
        }
        if ((hasPlayer && Input.GetKeyDown(KeyCode.R)) || (hasPlayer && Input.GetButtonDown("PickUp")))
        {
            rb.constraints = RigidbodyConstraints.FreezeAll;
            transform.parent = player;
            beingCarried = true;
                pc.currentSpeed = 100;
            Debug.Log("picked");
        }
        if (beingCarried)
        {
            //Win();
            /*if (touched)
            {
                rb.constraints = RigidbodyConstraints.None;
                transform.parent = null;
                beingCarried = false;
                touched = false;
            }*/
            if ((Input.GetKeyDown(KeyCode.T)) || Input.GetButtonDown("Throw"))
            {
                rb.constraints = RigidbodyConstraints.FreezeAll;
                transform.parent = null;
                pc.currentSpeed = 200;
                Debug.Log("thrown");
            }
        }
    }

    /*void Win()
    {
        winscreen.SetActive(true);
    }*/
}
