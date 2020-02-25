using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class EndSceneManager : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    bool sentenceCompleted = false;

    public GameObject endSceneManager;
    public GameObject continueButton;
    //public GameObject instructionLog;
    public AudioSource typingAudio;

    public GameObject bg1;
    public GameObject bg2;
    public GameObject bg3;
    public GameObject bg4;
    public GameObject bg5;

    void Start()
    {
        //StartCoroutine(Typing());
        //StartCoroutine(ShowBG());
    }

    // Update is called once per frame
    void Update()
    {
        if (index >= sentences.Length)
        {
            //instructionLog.SetActive(true);
            SceneManager.LoadScene(0);
            return;
        }

        if (Input.GetKeyDown(KeyCode.Space) && sentenceCompleted == true || Input.GetButtonDown("Interact") && sentenceCompleted == true)
        {
            sentenceCompleted = false;
            NextSentence();
            Debug.Log("esm1");
        }
    }

    public IEnumerator Typing()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            typingAudio.Play();

            yield return new WaitForSeconds(typingSpeed);
            Debug.Log("esm2");
        }

        sentenceCompleted = true;
        continueButton.SetActive(true);
        Debug.Log("esm3");
    }

    public void NextSentence()
    {

        continueButton.SetActive(false);

        if (index < sentences.Length)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
            bg5.SetActive(false);
        }
    }

    public IEnumerator ShowBG()
    {
        bg1.SetActive(true);
        yield return new WaitForSeconds(2f);
        bg1.SetActive(true);
        yield return new WaitForSeconds(2f);
        bg1.SetActive(false);
        bg2.SetActive(true);
        yield return new WaitForSeconds(4f);
        bg2.SetActive(false);
        bg3.SetActive(true);
        yield return new WaitForSeconds(4f);
        bg3.SetActive(false);
        bg4.SetActive(true);
        yield return new WaitForSeconds(3f);
        bg4.SetActive(false);
        bg5.SetActive(true);
    }
}
