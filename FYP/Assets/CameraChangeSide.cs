using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChangeSide : MonoBehaviour
{
    //public CameraFollow cf;
    public GameObject mainCam;
    public GameObject MidCam;
    public Camera mainCamRef;
    public Camera MidCamRef;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void SideCamActive()
    {
        mainCamRef.enabled = true;
        mainCam.SetActive(true);
        MidCamRef.enabled = false;
        MidCam.SetActive(false);
        PlayerControls.instance.referenceCam = mainCamRef;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SideCamActive();
        }
    }
}
