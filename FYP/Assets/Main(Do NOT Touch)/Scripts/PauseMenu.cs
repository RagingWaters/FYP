using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuScreen;
    public GameObject transition;
    public GameObject buttonToSelect;
    public GameObject inv;
    public EventSystem es;


    public GameObject instructionScreen;
    public GameObject ints;
    public GameObject screen1;
    public GameObject screen2;
    PlayerController pc;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetButtonDown("Pause"))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

    }

    //For Instructions
    public void Instructions()
    {
        ints.SetActive(true);
        screen1.SetActive(false);
        screen2.SetActive(false);
    }

    public void Screen1()
    {
        ints.SetActive(false);
        screen1.SetActive(true);
        screen2.SetActive(false);
    }

    public void Screen2()
    {
        ints.SetActive(false);
        screen1.SetActive(false);
        screen2.SetActive(true);
    }

    public void CloseInstructions()
    {
        instructionScreen.SetActive(false);
    }

    // Resume Button
    public void Resume()
    {
        pauseMenuScreen.SetActive(false);
        es.SetSelectedGameObject(inv);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    // Pause Button
    void Pause()
    {
        pauseMenuScreen.SetActive(true);
        es.SetSelectedGameObject(buttonToSelect);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    // Button back to Main Menu
    public void ToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main New");
        Debug.Log("MAIN MENU");
    }

}
