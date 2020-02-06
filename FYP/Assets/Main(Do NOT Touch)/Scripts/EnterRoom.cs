using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterRoom : MonoBehaviour
{
    public GameObject Activecam;
    public CameraFollow cf;
    public Camera testCam;
    public static bool inRoom = false;

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
        inRoom = true;
        testCam.enabled = true;
        Camera.main.enabled = false;
        PlayerControls.instance.referenceCam = testCam;
        PlayerControls.instance.referenceCam.transform.position = Activecam.transform.position;
        PlayerControls.instance.referenceCam.transform.rotation = Activecam.transform.rotation;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && inRoom == false)

        {
            print("In room");
            ChangeCamPos();
        }
    }
}
