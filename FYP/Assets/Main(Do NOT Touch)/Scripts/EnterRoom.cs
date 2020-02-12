using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterRoom : MonoBehaviour
{
    public GameObject Activecam;
    public CameraFollow cf;
    public Camera RoomCam;
    public Camera mainCam;
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
        RoomCam.enabled = true;
        mainCam.enabled = false;
        PlayerControls.instance.referenceCam = RoomCam; 
        PlayerControls.instance.referenceCam.transform.position = Activecam.transform.position;
        PlayerControls.instance.referenceCam.transform.rotation = Activecam.transform.rotation;
    }

    void CamSwitch()
    {
        PlayerControls.instance.referenceCam.transform.position = Activecam.transform.position;
        PlayerControls.instance.referenceCam.transform.rotation = Activecam.transform.rotation;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && inRoom == false)

        {
            ChangeCamPos();
        }

        if (other.gameObject.tag == "Player" && inRoom == true)

        {
            CamSwitch();
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && inRoom == false)

        {
            ChangeCamPos();
        }

        if (other.gameObject.tag == "Player" && inRoom == true)

        {
            CamSwitch();
        }
    }
}
