using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{
    public Camera referenceCam;
    Rigidbody rb;


    public float currentSpeed;
    public float moveSpeedNorm;
    public float moveRunSpeed;
       

    public float turnSpeed = 15;
    public float horizontalInput, verticalInput;
    public float frameStorage;
    private float storedInputH, storedInputV;
    public bool isMoving;

    public LayerMask groundLayer;
    public float jumpForce = 5;
    public SphereCollider col;

    public Vector3 respawnPosition;

    public Vector3 position;

    public LevelManager theLevelmanager;

    // this is so that other scripts can access its components
    public static PlayerControls instance;

    public int articleValue;

    public GameObject[] players;

    public enemyController[] enemies;

    // to stop rotation and movement
    public bool freezeRotation;
    public AudioSource source;
    public Animator anim;



    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        referenceCam = Camera.main;
        rb = GetComponent<Rigidbody>();
        col = GetComponent<SphereCollider>();
        source = GetComponent<AudioSource>();
        


        currentSpeed = 5;

        respawnPosition = transform.position;



        theLevelmanager = FindObjectOfType<LevelManager>();

        players = GameObject.FindGameObjectsWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        if (DialogueTrigger.isTalking) return;
        //transform.Translate(currentSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, currentSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
        Inputs();

        FrameStoring();

        if (isMoving)
        {
            anim.SetBool("isMoving", true);
            Movement();
        }
        else
        {
            rb.velocity = Vector3.up * rb.velocity.y;
            anim.SetBool("isMoving", false);
            //  currentSpeed = 5;
        }
     
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //rb.AddForce(Vector3.up * jumpForce, ForceMode.impluse);
        }
        enemies = FindObjectsOfType<enemyController>();
    }
    private void LateUpdate()
    {
        rb.AddRelativeForce(Physics.gravity * 10, ForceMode.Acceleration);
    }
    void Inputs()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    void FrameStoring()
    {
        isMoving = (horizontalInput != 0 || verticalInput != 0);
        if (horizontalInput == 0 || verticalInput == 0)
        {
            frameStorage -= 1;
        }
        else if (horizontalInput != 0 && verticalInput != 0)
        {
            frameStorage = 3;
            storedInputH = horizontalInput;
            storedInputV = verticalInput;
        }
    }
    public void Movement()
    {
        Vector3 forward = referenceCam.transform.forward;
        Vector3 right = referenceCam.transform.right;
        forward.y = 0;
        right.y = 0;
        Vector3 moveDirection = (forward * verticalInput + right * horizontalInput).normalized * currentSpeed;
        rb.velocity = new Vector3(moveDirection.x, rb.velocity.y, moveDirection.z);
        
        


        if (frameStorage <= 2 && frameStorage >= 0)
        {
            rb.velocity = Vector3.up * rb.velocity.y;
        }

        // rotates the player
        if (frameStorage > 0)
        {

            float hlInput = horizontalInput == 0 ? storedInputH : horizontalInput;
            float vInput = verticalInput == 0 ? storedInputV : verticalInput;
          if(!freezeRotation)  transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(forward * vInput + right * hlInput).normalized, .2f);
        }
        else if (frameStorage <= 0 &&  (!freezeRotation)) transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(moveDirection), .2f);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Collision Detected");
            theLevelmanager.gameOver();
             //theLevelmanager.MinusArticle(articleValue);
        }

    }

}
