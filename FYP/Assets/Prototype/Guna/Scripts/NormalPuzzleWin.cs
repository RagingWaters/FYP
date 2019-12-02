using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalPuzzleWin : MonoBehaviour
{
    public bool Correct1 = false;
    public bool Correct2 = false;
    public bool Correct3 = false;
    public Item toyReward;
    private bool reward = false;
    public GameObject correct;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Correct1 == true && Correct2 == true && Correct3 == true && reward == false)
        {
            Inventory.instance.Add(toyReward);
            print("Ez game boys");
            reward = true;
            StartCoroutine(StopDialogue());
        }

    }
    IEnumerator StopDialogue()
    {

        correct.SetActive(true);
        yield return new WaitForSeconds(4f);
        correct.SetActive(false);
    }
}
