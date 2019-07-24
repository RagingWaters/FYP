﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public GameObject winscreen;
    private static int Current;

    public float waitToRespawn;
    public PlayerControls Player; //Make a reference to an object of PlayerController


    public Transform[] PlayerspawnPoints;

    public static int currentLevel, maxLevel;

    public GameObject newspaperText;
    private Animation anim;
    //public static int theScore;

   [SerializeField] private int currentScore;

    public GameObject gameOverScreen;

    public Slider staminaSlider;

    // Start is called before the first frame update
    void Start()
    {
        //theScore = 0;
        //newspaperText.GetComponent<Text>().text = "Pieces : " + currentScore + " / 4";

    }

    // Update is called once per frame
    void Update()
    {
        //currentScore = Collectible.theScore;
        // currentScore = collectg.theScore;

        /*
        if (currentScore <= 0)
            currentScore = 0;
        else
            currentScore = 0;
        */

       if (currentScore >= 4)
        {
            newspaperText.SetActive(true);
            Win();
        }
    }

    void Win()
    {
        winscreen.SetActive(true);
        /*Current = 0;
        Collectible.theScore = Current;*/
    }

    void gameOver()
    {
        newspaperText.SetActive(false);
        gameOverScreen.SetActive(true);
        staminaSlider.gameObject.SetActive(false);

    }

    public void Respawn()
    {
        if (currentScore > -1)
        {
            StartCoroutine("RespawnCo");
        }
        else
        {
            newspaperText.SetActive(false);
            Player.gameObject.SetActive(false);
           gameOver();
       }
    }

    public IEnumerator RespawnCo()
    {
        Player.gameObject.SetActive(false);  //Deactivate the player in the world

        yield return new WaitForSeconds(waitToRespawn); //How many second we want the game to wait for

        Player.transform.position = PlayerspawnPoints[Random.Range(0, 3)].position;

         
        Player.gameObject.SetActive(true); //Reactivate the player in the world.
    }

    public void AddArticle(int ArticleToAdd)
    {
        currentScore += ArticleToAdd;
        StartCoroutine(TextAnimation());
    }

    public void MinusArticle(int ArticleToMinus)
    {
        if (currentScore > -1)
        {
            currentScore -= ArticleToMinus;
            StartCoroutine(TextAnimation());
        }

        else
        {

            Player.gameObject.SetActive(false);
            gameOver();
            

        }
    }

    IEnumerator TextAnimation()
    {
        newspaperText.SetActive(true);
        anim = newspaperText.GetComponent<Animation>();
        // theScore--++;
        newspaperText.GetComponent<Text>().text = "Pieces : " + currentScore + " / 4";
        yield return new WaitUntil(() => !anim.isPlaying);
        Debug.Log("Article Count Update");
        newspaperText.SetActive(false);
    }

}

