using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialObject1 : MonoBehaviour
{
    public tutorialwin tw;    

    Animator m_Animator;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
        tw = FindObjectOfType<tutorialwin>();
    }

    void Update()
    {      
       // Debug.Log(tw.Correct1);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "1")
        {
            tw.Correct1 = true;
            m_Animator.SetBool("Box Opened 1", true);
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
