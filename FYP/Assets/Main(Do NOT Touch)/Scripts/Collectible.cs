using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectible : MonoBehaviour
{
    // Start is called before the first frame update //

    public GameObject scoreText;
    public int theScore;

    public void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.Space) && other.tag == "Player")
        {
            Debug.Log("Collected");
            theScore += 1;
            scoreText.GetComponent<Text>().text = "Pieces : " + theScore;
            Destroy(gameObject);
        }
    }
}
