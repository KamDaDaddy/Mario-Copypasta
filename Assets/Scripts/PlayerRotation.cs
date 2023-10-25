using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public float rotationSpeed = 100f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0f, rotation, 0f);
    }
}
