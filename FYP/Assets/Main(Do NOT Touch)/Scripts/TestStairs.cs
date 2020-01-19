using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestStairs : MonoBehaviour
{

    public GameObject player;
    public Transform Target;
    private bool cd;
    public GameObject sepiaFilter;
    
    public GameObject timeCrack;
    public GameObject fadePanel;
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
        fadePanel.SetActive(true);
        player.transform.position = Target.transform.position;
        yield return new WaitForSeconds(1f);
        fadePanel.SetActive(false);
        sepiaFilter.SetActive(false);
        //Inventory.instance.Add(toyReward);
        yield return new WaitForSeconds(2f);
        timeCrack.SetActive(true);
        
       // cd = false;
    }

}
