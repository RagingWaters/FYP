using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PrologueManager : MonoBehaviour
{

    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    bool sentenceCompleted = false;

    private int indexx;

    public GameObject continueButton;
    //public Image blackBG;
    public GameObject prelogueManager;
    public GameObject instructionLog;
    public AudioSource audio;

    public GameObject bg1;
    public GameObject bg2;
    public GameObject bg3;
    public GameObject bg4;
    public GameObject bg5;


    void Start()
    {
        //continueButton.SetActive(false);
        StartCoroutine(Type());
        StartCoroutine(Show());
    }

    void Update()
    {
        if (index >= sentences.Length)
        {
            instructionLog.SetActive(true);
            prelogueManager.SetActive(false);
            return;
        }

        if (Input.GetKeyDown(KeyCode.Space) && sentenceCompleted == true || Input.GetButtonDown("Interact") && sentenceCompleted == true)
        {
            sentenceCompleted = false;
            NextSentence();
        }
    }

    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            audio.Play();
            
            yield return new WaitForSeconds(typingSpeed);
        }

        sentenceCompleted = true;
        continueButton.SetActive(true);
    }

    public void NextSentence()
    {

        continueButton.SetActive(false);

        if (index < sentences.Length)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
            bg5.SetActive(false);
        }        
    }

    IEnumerator Show()
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
