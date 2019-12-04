using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item item;
    //private Animator anim;
    //public AudioClip clip;
    //public AudioSource source;

    void Start()
    {
        //anim = GetComponent<Animator>();
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Input.GetKeyDown(KeyCode.Space) || other.tag == "Player" && Input.GetButtonDown("Interact"))
        {
            PickUp();
            //source.PlayOneShot(clip);
        }
    }

    void PickUp()
    {
        Debug.Log("Picking up " + item.name);
        item.prompt = GetComponent<prompt>().promptopt;
        bool wasPickedUp = Inventory.instance.Add(item);

        if(wasPickedUp)
        {
            //anim.SetBool("wasPickedUp", true);
            GetComponent<prompt>().promptopt.SetActive(false);
            Destroy(gameObject);
        }
    }
}
