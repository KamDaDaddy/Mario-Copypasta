using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class ObjectLifeTime : MonoBehaviour
{
    private float secondsLifeTime = 3.2f;
    private PlayerController controllerScript;
    
    // Start is called before the first frame update
    void Start()
    {
        controllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, secondsLifeTime);
    }

    
}
