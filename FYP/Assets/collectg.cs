using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectg : MonoBehaviour
{

    public LevelManager theLevelManager;
    public int articleValue;

    public GameObject newspaperText;
    private Animation anim;

    //public static int theScore;


    // Start is called before the first frame update
    void Start()
    {
        theLevelManager = FindObjectOfType<LevelManager>();
        //theScore = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                theLevelManager.AddArticle(articleValue);
                print("added");
                Destroy(gameObject);
            }
        }
    }
}

            //void OnTriggerEnter(Collider collision)
            //{
            //    if (collision.gameObject.tag == "Player")
            //    {
            //        theLevelManager.AddArticle(articleValue);
            //        print("added");
            //        Destroy(gameObject);
            //    }
            //}
    
