using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScareManagement : MonoBehaviour
{
    public GameObject scare1;
    public static bool puzzleCompleted1; // If Puzzle A is completed...



    void Start()
    {
        
    }

    void Update()
    {
        if (puzzleCompleted1 == true)
            StartCoroutine(ScareAnim1());
    }


    IEnumerator ScareAnim1()
    {
        scare1.SetActive(true);

        yield return new WaitForSeconds(1f);

        scare1.SetActive(false);
    }










}
