﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");

    }

    public void Restart()
    {
        SceneManager.LoadScene("Main");
    }
}
