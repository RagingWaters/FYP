using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitRoom : MonoBehaviour
{
    public CameraFollow cf;
    public Camera testCam;
    public Camera mainCam;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void ChangeCamPos()
    {
        EnterRoom.inRoom = false;
        mainCam.enabled = true;
        testCam.enabled = false;
        PlayerControls.instance.referenceCam = mainCam;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && EnterRoom.inRoom == true)
        {
            print("Outside room");
            ChangeCamPos();
        }
    }
}
