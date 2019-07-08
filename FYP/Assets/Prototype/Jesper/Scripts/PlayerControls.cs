using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public Camera mainCam;
    Rigidbody rb;

    public float moveSpeed;
    public float turnSpeed = 10;
    public float horizontalInput, verticalInput;
    public float frameStorage;
    private float storedInputH, storedInputV;
    bool isMoving;

    public LayerMask groundLayer;
    public float jumpForce = 5;
    public SphereCollider col;

    // Start is called before the first frame update
    void Start()
    {
        mainCam = Camera.main;
        rb = GetComponent<Rigidbody>();
        col = GetComponent<SphereCollider>();


        moveSpeed = 5;
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
        Inputs();

        FrameStoring();

        if (isMoving)
            Movement(); 
            else rb.velocity = Vector3.up * rb.velocity.y;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //rb.AddForce(Vector3.up * jumpForce, ForceMode.impluse);
        }
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
        Vector3 moveDirection = (forward * verticalInput + right * horizontalInput).normalized * moveSpeed;
        rb.velocity = new Vector3(moveDirection.x, rb.velocity.y, moveDirection.z);


        if (frameStorage <= 2 && frameStorage >= 0) { 
           rb.velocity = Vector3.up * rb.velocity.y;
        }

        // rotates the player
        if (frameStorage > 0)
        {
            
            float hlInput = horizontalInput == 0 ? storedInputH : horizontalInput;
            float vInput = verticalInput == 0 ? storedInputV : verticalInput;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(forward * vInput + right * hlInput).normalized, .2f);
        }
        else if(frameStorage <= 0) transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(moveDirection), .2f);
    }

}
