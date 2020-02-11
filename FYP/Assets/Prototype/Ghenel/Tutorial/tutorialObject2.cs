using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialObject2 : MonoBehaviour
{
    public tutorialwin tw;

    Animator m_Animator;
   public AudioManager am;
    void Start()
    {        
        m_Animator = gameObject.GetComponent<Animator>();
        tw = FindObjectOfType<tutorialwin>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "2")
        {
            tw.Correct2 = true;
            m_Animator.SetBool("Box Opened 1", true);
            am.Box();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "2")
        {
            tw.Correct2 = false;
        }
    }
}
