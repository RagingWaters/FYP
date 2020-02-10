using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateBoxUponCompletion : MonoBehaviour
{
    public tutorialwin tw;
    
    Animator m_Animator;
    bool boxOpened;

    private Animation boxAnim;




    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponentInParent<Animator>();
        tw = FindObjectOfType<tutorialwin>();

        //boxAnim = gameObject.GetComponent<Animation>();
    }

    void Update()
    {
        if (tw.Correct1 == true)
        {
            m_Animator.SetBool("Box Opened", true);

           // boxAnim.Play("boxopen");
        }

            

        //Debug.Log(tw.Correct1);

    }
}
