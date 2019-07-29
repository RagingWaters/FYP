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
    [SerializeField] Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
       // player = FindObjectOfType<PlayerController>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, player.position);
        if (dist <= 2.5f)
        {
            hasPlayer = true;
            Debug.Log("in range");
        }
        else
        {
            hasPlayer = false;

        }
        if (hasPlayer && Input.GetKeyDown(KeyCode.R))
        {
            //GetComponent<Rigidbody>().isKinematic = false;
            transform.parent = player;
            beingCarried = true;
            Debug.Log("picked");
        }
        if (beingCarried)
        {
            if (touched)
            {
                transform.parent = null;
                beingCarried = false;
                touched = false;
            }
            if (Input.GetKeyDown(KeyCode.T))
            {
                transform.parent = null;
                rb.AddForce(player.transform.forward * throwForce);
                Debug.Log("thrown");
            }

        }


    }
     /*void OnTriggerEnter()
    {
        if (beingCarried)
        {
            touched = true;
        }
    }*/
}
