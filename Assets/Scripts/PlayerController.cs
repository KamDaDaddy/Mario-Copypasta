using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Public variables
    public int speed = 10;
    
    
    public ParticleSystem dirtParticleSystem;
    public bool onGround = true;
    public float horizontalInput;
    public float verticalInput;

    //Private variables
    private float turnSpeed = 100.0f;
    private Rigidbody playerRb;
    private Animator playerAnim;
    private bool isMoving;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GameObject.FindWithTag("Player").GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();

        dirtParticleSystem.Stop();
    }

    // Update is called once per frame
    void Update()
    {
    //Getting the horizontal/vertical axis for A D & W S movement
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

    //Uses W S & A D movement
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

    //Check if keys A or D are being pressed, if so, rotate player internally.
        if(horizontalInput > 0.1f)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed, Space.Self);
        }
    
        if(horizontalInput < 0.1f)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * -turnSpeed, Space.Self);
        }

    }

}
