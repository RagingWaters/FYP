using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    //public GameObject winscreen;
    private static int Current;

    public float waitToRespawn;
    public PlayerControls Player; //Make a reference to an object of PlayerController


    public Transform[] PlayerspawnPoints;

    public static int currentLevel, maxLevel;

    public GameObject newspaperText;
    private Animation anim;
    //public static int theScore;

   [SerializeField] private int currentScore;
   [SerializeField] private int currentCross;
   [SerializeField] public int currentKey;
   [SerializeField] public int currentShovel;
   [SerializeField] public int currentCigg;
   [SerializeField] public int currentTorch;
   [SerializeField] public int currentJournal;
   [SerializeField] public int currentClock;
   [SerializeField] public int currentPages;
   [SerializeField] public int currentTalisman;
   [SerializeField] public int currentCandles;

    public GameObject gameOverScreen;
    public GameObject option;
    public GameObject tasklistbtn;

    public Slider staminaSlider;

   // public GameObject Door;
   // public GameObject LastDoor;
    public GameObject torchdoor;
    public GameObject warning;
    public GameObject warningwrong;
    public GameObject Door1;

    public GameObject o1;
    public GameObject o2;

    public GameObject keypotopt;
    public GameObject foundkey;
    public GameObject warning0shovel;
    public GameObject keyy;
    public GameObject warningnth;
    public GameObject cigg;
    public GameObject foundcigg;
    public GameObject randompotopt;

    public GameObject L2blocker;
    public GameObject L3blocker;
    public GameObject L4blocker;





    // Start is called before the first frame update
    void Start()
    {


        //keyy.SetActive(false);
        //theScore = 0;
        //newspaperText.GetComponent<Text>().text = "Pieces : " + currentScore + " / 4";
    }

    // Update is called once per frame
    void Update()
    {

    }

    //public void Win()
    //{
    //    if (currentTalisman == 1)
    //    {
    //        Debug.Log("1 Talismamn");
    //        winscreen.SetActive(true);
    //        /*Current = 0;
    //        Collectible.theScore = Current;*/
    //    }
    //}

    public void gameOver()
    {
        option.SetActive(false);

       // newspaperText.SetActive(false);
       // tasklistbtn.SetActive(false);
        gameOverScreen.SetActive(true);
        staminaSlider.gameObject.SetActive(false);
        Player.gameObject.SetActive(false);
    }

    public void OpenAnyDoor(GameObject warning)
    {
        if (currentKey == 1)
        {
            torchdoor.SetActive(false);
            o1.SetActive(false);
        }
        else
        {
            warning.SetActive(true);
        }
    }
    public void Openwrongdoor()
    {
        if (currentKey ==1)
        {
            warningwrong.SetActive(true);
        }
        else
        {
            warning.SetActive(true);
        }
    }

    public void Openopendoors()
    {
        Door1.SetActive(false);
        o2.SetActive(false);
    }

    public void blocker1()
    {
        if (currentShovel == 1 && currentTorch == 1 && currentKey ==1)
        {
            L2blocker.SetActive(false);
        }
    }

    public void blocker2()
    {
        if (currentJournal == 1 )
        {
            L3blocker.SetActive(false);
        }
    }

    public void blocker3()
    {
        if (currentClock == 1)
        {
            L4blocker.SetActive(false);
        }
    }

    //public void digpot()
    //{
    //    if (currentShovel == 1)
    //    {
    //        foundkey.SetActive(true);
    //        keypotopt.SetActive(true);
    //        keyy.SetActive(true);         
    //    }
    //    else
    //    {
    //        warning0shovel.SetActive(true);
    //    }
    //}

    //public void gottorchspawnenemy()
    //{
    //    if (currentTorch == 1)
    //    {
    //        enemySpawner.startSpawn = true;
    //    }
    //    else
    //    {
    //        enemySpawner.startSpawn = false;
    //    }
    //}

    public void digrandompot()
    {
        if (currentShovel == 1)
        {
            foundcigg.SetActive(true);
            cigg.SetActive(true);
            randompotopt.SetActive(false);
            
        }
        else
        {
            warning0shovel.SetActive(true);
        }
    }

    public void digemptypot()
    {
        if (currentShovel == 1)
        {
            warningnth.SetActive(true);
        }
        else
        {
            warning0shovel.SetActive(true);
        }
    }


    public void AddCross(int CrossToAdd)
    {
        currentCross += CrossToAdd;
    }

    public void AddKey(int KeyToAdd)
    {
        currentKey += KeyToAdd;
    }

    public void AddTorch(int TorchtoAdd)
    {
        currentTorch += TorchtoAdd;
    }

    public void AddShovel(int ShovelToAdd)
    {
        currentShovel += ShovelToAdd;

    }

    public void AddCigg(int ciggToAdd)
    {
        currentCigg += ciggToAdd;

    }

    public void AddJournal( int JournalToAdd)
    {
        currentJournal += JournalToAdd;
    }

    public void AddClock(int ToyToAdd)
    {
        currentClock += ToyToAdd;
    }

    public void AddTalisman(int TalismanToAdd)
    {
        currentTalisman += TalismanToAdd;
    }

    public void AddCandles(int CandlesToAdd)
    {
        currentTalisman += CandlesToAdd;
    }


    public void AddPage(int PageToAdd)
    {
        currentPages += PageToAdd;
    }

        public IEnumerator RespawnCo()
    {
        Player.gameObject.SetActive(false);  //Deactivate the player in the world

        yield return new WaitForSeconds(waitToRespawn); //How many second we want the game to wait for

        Player.transform.position = PlayerspawnPoints[Random.Range(0, 3)].position;

         
        Player.gameObject.SetActive(true); //Reactivate the player in the world.
    }



}   
    //void OpenDoor()
    //{
    //    Door.SetActive(false);
    //}

    //void Openlastdoor()
    //{
    //    LastDoor.SetActive(false);
    //}

    //IEnumerator TextAnimation()
    //{
    //    newspaperText.SetActive(true);
    //    anim = newspaperText.GetComponent<Animation>();
    //    // theScore--++;
    //    newspaperText.GetComponent<Text>().text = "Pieces : " + currentScore + " / 4";
    //    yield return new WaitUntil(() => !anim.isPlaying);
    //    Debug.Log("Article Count Update");
    //    newspaperText.SetActive(false);
    //}

    //public void AddArticle(int ArticleToAdd)
    //{
    //    currentScore += ArticleToAdd;
    //    StartCoroutine(TextAnimation());
    //}

    //public void MinusArticle(int ArticleToMinus)
    //{
    //    if (currentScore > -1)
    //    {
    //        currentScore -= ArticleToMinus;
    //        StartCoroutine(TextAnimation());
    //    }

    //    else
    //    {

    //        Player.gameObject.SetActive(false);
    //        gameOver();
            

    //    }
    //}

    //public void Respawn()
    //{
    //    if (currentScore > -1)
    //    {
    //        StartCoroutine("RespawnCo");
    //    }
    //    else
    //    {
    //        newspaperText.SetActive(false);
    //        Player.gameObject.SetActive(false);
    //       gameOver();
    //   }
    //}

    //public void Opentorchdoorr()
    //{
    //    if (currentKey == 1)
    //    {
    //        torchdoor.SetActive(false);
    //        o1.SetActive(false);
    //    }
    //    else
    //    {
    //        warning.SetActive(true);
    //    }
    //}
    
    //currentScore = Collectible.theScore;
       // // currentScore = collectg.theScore;

       // /*
       // if (currentScore <= 0)
       //     currentScore = 0;
       // else
       //     currentScore = 0;
       // */

       //if (currentScore == 4)
       // {
       //     newspaperText.SetActive(true);
       //     //Win();
       //     OpenDoor();
       // }

       // if (currentKey == 1 && currentCross == 1)
       // {
       //     Debug.Log("1 key 1 cross");
       //     Openlastdoor();
       // }