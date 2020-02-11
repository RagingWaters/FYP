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

    public GameObject continueButton;
    public Image blackBG;
    public GameObject prelogueManager;
    public GameObject instructionLog;
    public AudioSource audio;


     void Start()
    {
        //continueButton.SetActive(false);
        StartCoroutine(Type());       
    }

    void Update()
    {
        if (index >= sentences.Length)
        {
            prelogueManager.SetActive(false);
            instructionLog.SetActive(true);
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
        }        
    }
    
}
