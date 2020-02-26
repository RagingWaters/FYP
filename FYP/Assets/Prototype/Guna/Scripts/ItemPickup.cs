using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item item;
    //public Animator animator;
    //public AudioClip clip;
    //public AudioManager source;
    //public GameObject icons;

    void Start()
    {
        //anim = GetComponent<Animator>();
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Input.GetKeyDown(KeyCode.Space) || other.tag == "Player" && Input.GetButtonDown("Interact"))
        {
            PickUp();
            //source.Pickup();
        }
    }

    void PickUp()
    {
        Debug.Log("Picking up " + item.name);  
        bool wasPickedUp = Inventory.instance.Add(item);

        if(wasPickedUp)
        {
            Destroy(gameObject);
        }
    }
}
