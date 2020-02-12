using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    //public CameraFollow cf;
    public GameObject mainCam;
    public GameObject MidCam;
    public Camera MidSecCam;
    public Camera mainCamRef;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void MidCamActive()
    {
        MidSecCam.enabled = true;
        MidCam.SetActive(true);
        mainCamRef.enabled = false;
        mainCam.SetActive(false);
        PlayerControls.instance.referenceCam = MidSecCam;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            MidCamActive();
        }
    }
}
