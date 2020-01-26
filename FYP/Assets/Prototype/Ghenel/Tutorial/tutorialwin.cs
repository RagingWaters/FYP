using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialwin : MonoBehaviour
{
    public bool Correct1 = false;
    public bool Correct2 = false;
    //public Item toyReward;
    private bool called = false;
    public GameObject correct;
    public GameObject player;
    private bool cd;
    public GameObject wrongPanel;
    public GameObject npc;


    // Start is called before the first frame update
    void Start()
    {
        cd = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Correct1 == true && Correct2 == true == true && called == false)
        {
            //Inventory.instance.Add(toyReward);
            print("Ez game boys");
            called = true;
            StartCoroutine(StopDialogue());
            //Object.Instantiate(FadeTransition);

        }
        else
        {
            //StartCoroutine(Wrong());
        }

    }
    IEnumerator StopDialogue()
    {
        correct.SetActive(true);
        yield return new WaitForSeconds(4f);
        correct.SetActive(false);
        yield return new WaitForSeconds(1f);
        npc.SetActive(false);

        cd = false;
    }

    IEnumerator Wrong()
    {
        wrongPanel.SetActive(true);
        yield return new WaitForSeconds(2f);
        wrongPanel.SetActive(false);

    }

}
