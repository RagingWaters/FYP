using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FlashBackDialog : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject continueButton;
    public GameObject bubbles1;
    public GameObject bubbles2;
    public bool talked = false;
    public bool conversated = false;
    public bool convoDone = false;
    public static bool isListening;
    // Start is called before the first frame update
    void Start()
    {
        talked = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && conversated == false)
        {
            isListening = true;
            bubbles1.SetActive(true);
            print("detected");
            StartCoroutine(Dialogue());
            conversated = true;
        }
    }

    IEnumerator Dialogue()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            
            textDisplay.text += letter;
            print("talking");
            yield return new WaitForSeconds(typingSpeed);
            
           
        }
    }

    public void NextFunction()
    {
        continueButton.SetActive(false);
        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Dialogue());
        }
        else
        {
            textDisplay.text = "";
            convoDone = true;
            continueButton.SetActive(false);
            
            
        }
    }

    public void Bubbles()
    {
        if(talked == false)
        {
            print("false");
            talked = true;
            bubbles1.SetActive(true);
            bubbles2.SetActive(false);
        }

        else if (convoDone == true)
        {
            bubbles1.SetActive(false);
            isListening = false;
            return;
        }

        else if (talked == true)
        {
            print("true");
            talked = false;
            bubbles1.SetActive(false);
            bubbles2.SetActive(true);
           
        }

      

        else
        {
            return;
        }
    }
    public void Talking()
    {
        NextFunction();
        Bubbles();
    }
}
