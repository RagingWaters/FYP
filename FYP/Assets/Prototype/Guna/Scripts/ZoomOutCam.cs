using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomOutCam : MonoBehaviour
{
    public GameObject ZoomoutCam;
    public GameObject StoredCam;
    public static bool zoomedIn = false;
    public CameraFollow MainCamcf;
    public CameraFollow MidCamcf;

    // Start is called before the first frame update
    void Start()
    {
        StoredCam.transform.position = Camera.main.transform.position;
        StoredCam.transform.rotation = Camera.main.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && zoomedIn == false ||   Input.GetButtonDown("ZoomOut") && zoomedIn == false)
        {
            MainCamcf.enabled = false;
            MidCamcf.enabled = false;
            StoredCam.transform.position = PlayerControls.instance.referenceCam.transform.position;
            StoredCam.transform.rotation = PlayerControls.instance.referenceCam.transform.rotation;
            print("zoomOut");
            ZoomCam();
        }

        else if (Input.GetKeyDown(KeyCode.Z) && zoomedIn == true || Input.GetButtonDown("ZoomOut") && zoomedIn == true)
        {
            MainCamcf.enabled = true;
            MidCamcf.enabled = true;
            print("zoomOut");
            OriginalCam();
        }
    }

    void ZoomCam()
    {
        PlayerControls.instance.referenceCam.transform.position = ZoomoutCam.transform.position;
        PlayerControls.instance.referenceCam.transform.rotation = ZoomoutCam.transform.rotation;
        zoomedIn = true;
    }

    void OriginalCam()
    {
        PlayerControls.instance.referenceCam.transform.position = StoredCam.transform.position;
        PlayerControls.instance.referenceCam.transform.rotation = StoredCam.transform.rotation;
        zoomedIn = false;
    }

}
