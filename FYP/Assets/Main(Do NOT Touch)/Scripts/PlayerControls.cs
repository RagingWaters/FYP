using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{
    public Camera mainCam;
    Rigidbody rb;

    public float currentSpeed;
    public float moveSpeedNorm;
    public float moveRunSpeed;
       

    public float turnSpeed = 50;
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

    public static PlayerControls instance;

    public int articleValue;

    public GameObject[] players;

    public enemyController[] enemies;
   



    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        mainCam = Camera.main;
        rb = GetComponent<Rigidbody>();
        col = GetComponent<SphereCollider>();


        currentSpeed = 200;

        respawnPosition = transform.position;



        theLevelmanager = FindObjectOfType<LevelManager>();

        players = GameObject.FindGameObjectsWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(currentSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, currentSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
        Inputs();

        FrameStoring();

        if (isMoving)
            Movement();
        else rb.velocity = Vector3.up * rb.velocity.y;
        //  currentSpeed = 5;
     
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
    void Movement()
    {
        Vector3 forward = mainCam.transform.forward;
        Vector3 right = mainCam.transform.right;
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
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(forward * vInput + right * hlInput).normalized, .2f);
        }
        else if (frameStorage <= 0) transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(moveDirection), .2f);
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
