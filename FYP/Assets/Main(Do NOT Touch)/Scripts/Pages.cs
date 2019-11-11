using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pages : MonoBehaviour
{
    public GameObject page;
    public GameObject pageGO;
    public PlayerControls pc;
    public LevelManager lm;
    public int pageValue;
    
    // Start is called before the first frame update
    void Start()
    {
        pc = FindObjectOfType<PlayerControls>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")

        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Interact"))
            {
                page.SetActive(true);
                pc.enabled = false;
                Time.timeScale = 0;
                
                lm.AddPage(pageValue);
                
                Debug.Log("Page Added");
                
                
                
            }

            else
            {
                
            }
        }
    }

    public void Unpause()
    {
        Time.timeScale = 1;
        pc.enabled = true;
        page.SetActive(false);
        pageGO.SetActive(false);
        
    }



}
