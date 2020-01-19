using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestStairs : MonoBehaviour
{

    public GameObject player;
    public Transform Target;
    private bool cd;
    public GameObject sepiaFilter;
    public GameObject npc;
    public GameObject timeCrack;

    void Start()
    {
        //cd = false;
    }


    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" )
        {
            if (Input.GetKeyDown(KeyCode.Space) && cd == false || Input.GetButtonDown("Interact") && cd == false)
            {

               // cd = true;
                StartCoroutine(Teleport());
            }
        }
    }

    IEnumerator Teleport()
    {
        player.transform.position = Target.transform.position;
        
        sepiaFilter.SetActive(false);
        //Inventory.instance.Add(toyReward);
        npc.SetActive(false);
        yield return new WaitForSeconds(2f);
        timeCrack.SetActive(true);
        
       // cd = false;
    }

}
