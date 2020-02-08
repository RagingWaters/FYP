using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    public Animation animToPlay;
    bool interacted;


    // Start is called before the first frame update
    void Start()
    {
        animToPlay = gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (interacted == true)
        {
           // anim.Play("this");
        }
    


    }
}
