using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterRoom : MonoBehaviour
{
    public GameObject Activecam;
    //public GameObject DisableCam;
    
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
        PlayerControls.instance.referenceCam.transform.position = Activecam.transform.position;
        PlayerControls.instance.referenceCam.transform.rotation = Activecam.transform.rotation;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")

        {
            print("HitPlyer");
            ChangeCamPos();
            //Activecam.SetActive(true);
            //DisableCam.SetActive(false);
            //PlayerControls.instance.referenceCam = Activecam.GetComponent<Camera>();
            // StartCoroutine(BigBoy());  
        }
    }


    //IEnumerator BigBoy()
    //{
    //    yield return new WaitForSeconds(1f);
    //    mainCam.SetActive(false);
    //}
}
