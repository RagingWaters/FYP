using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{

    public GameObject winscreen;
    private static int Current2;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
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
        SceneManager.LoadScene("Tutorial");
    }

    public void LeaveGame()
    {
        Application.Quit();
        Debug.Log("I QUIT !!");
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
