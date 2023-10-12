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
    //public float horizontalInput;
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
        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);

    //Rotating with A D into itself on the y axis
        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(collider.gameObject.CompareTag("Good"))
        {
            score = score + 2;
            Destroy(other.gameObject);
        }
    }


}
