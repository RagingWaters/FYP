using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialObject1 : MonoBehaviour
{
    public tutorialwin tw;    

    Animator m_Animator;
    bool boxOpened;

    // Start is called before the first frame update
    void Start()
    {
        //m_Animator = gameObject.GetComponent<Animator>();
        //tw = GetComponent<tutorialwin>();
    }

    void Update()
    {
        //if (tw.Correct1 == true)
           // m_Animator.SetBool("Box Opened", true);

       // Debug.Log(tw.Correct1);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "1")
        {
            tw.Correct1 = true;            
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "1")
        {
            tw.Correct1 = false;
        }
    }
}
