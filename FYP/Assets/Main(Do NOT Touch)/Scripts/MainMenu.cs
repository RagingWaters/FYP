﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


public class MainMenu : MonoBehaviour
{

    public GameObject winscreen;
    private static int Current2;
    public EventSystem es;
    private GameObject storedSelected;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        storedSelected = es.firstSelectedGameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (es.currentSelectedGameObject != storedSelected)
            if (es.currentSelectedGameObject == null)
                es.SetSelectedGameObject(storedSelected);
            else
                storedSelected = es.currentSelectedGameObject;
          
    }

    public void loadScene(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void MainMenuLoad()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Restart()
    {
        SceneManager.LoadScene("Test");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void Play()
    {
        SceneManager.LoadScene("Beta Main");
    }

    public void LeaveGame()
    {
        Application.Quit();
        Debug.Log("I QUIT !!");
    }

    public void ManuallySelectButton(GameObject buttonToSelect)
    {
        es.SetSelectedGameObject(buttonToSelect);
    }

    public void MainMenuGame()
    {
        Time.timeScale = 1f;
        /*Current2 = 0;
        Collectible.theScore = Current2;*/
        winscreen.SetActive(false); 
        SceneManager.LoadScene("MainMenu");
    }


}
