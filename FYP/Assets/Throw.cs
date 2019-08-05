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
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, player.position);
        if (dist <= 1.5f)
        {
            hasPlayer = true;
            Debug.Log("in range");
        }
        else
        {
            hasPlayer = false;
            rb.constraints = RigidbodyConstraints.None;
        }
        if ((hasPlayer && Input.GetKeyDown(KeyCode.R)) || (hasPlayer && Input.GetButtonDown("PickUp")))
        {
            transform.position = player.transform.position;
            rb.constraints = RigidbodyConstraints.FreezeAll;
            transform.parent = player;
            beingCarried = true;
            Debug.Log("picked");
        }
        if (beingCarried)
        {
            if (touched)
            {
                rb.constraints = RigidbodyConstraints.None;
                transform.parent = null;
                beingCarried = false;
                touched = false;
            }
            if ((Input.GetKeyDown(KeyCode.T)) || Input.GetButtonDown("Throw"))
            {
                rb.constraints = RigidbodyConstraints.None;
                transform.parent = null;
                rb.AddForce(player.transform.forward * throwForce);
                Debug.Log("thrown");
            }
        }
    }
}
