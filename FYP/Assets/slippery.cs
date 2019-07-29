using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slippery : MonoBehaviour
{

    public PlayerControls Player;
    PlayerControls playerControls;

    public GameObject torch;
    [SerializeField] Rigidbody rb;
    public float throwForce = 5f;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        playerControls = GetComponent<PlayerControls>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //if (playerControls.isMoving = true && Input.GetKey(KeyCode.LeftShift));
            if (Input.GetKey(KeyCode.LeftShift))
            {
                 //Destroy(GameObject.FindWithTag("Throwable"));
                GameObject item = GameObject.FindWithTag("Throwable");
                item.transform.parent = null;
            }
        }
        else
        {
            //Do nothing;
        }
    }
}
