using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxopen : MonoBehaviour
{
    public Animator anim;
    public tutorialwin tw;
    bool third = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tw.Correct1 == true && third == false)
        {
           // anim.Play("boxopen");
        }
    }
}
