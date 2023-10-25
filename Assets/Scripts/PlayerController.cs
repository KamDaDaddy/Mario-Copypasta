using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Public variables
    public int speed = 10;
    public int score;
    public ParticleSystem dirtParticleSystem;
    public bool onGround = true;
    public float horizontalInput;
    public float verticalInput;

    //Private variables
    private float turnSpeed = 300.0f;
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

    void Update()
    {
        //Forward and backward set up motion with the z axis
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);

    //Uses W S & A D movement
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

        if(horizontalInput > 0 || horizontalInput < 0 || verticalInput > 0 || verticalInput < 0)
        {
            playerAnim.SetBool("Is Moving", true);
        }
        else 
        {
            playerAnim.SetBool("Is Moving", false);
        }

    
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Good"))
        {
            ScoreManager.instance.AddScore(2);
            Destroy(collision.gameObject);
        }
        else if(collision.gameObject.CompareTag("Bad"))
        {
            ScoreManager.instance.AddScore(-1);
            Destroy(collision.gameObject);
        }


    }


}
