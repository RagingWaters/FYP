using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuScreen;
    public GameObject transition;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
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

    // Resume Button
    public void Resume()
    {
        pauseMenuScreen.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    // Pause Button
    void Pause()
    {
        pauseMenuScreen.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    // Button back to Main Menu
    public void ToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

}
