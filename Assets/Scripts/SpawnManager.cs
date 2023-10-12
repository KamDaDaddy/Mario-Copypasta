using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float startDelay;
    public float repeatRate;
    public GameObject[] objectsPrefabs;
    //private Vector3 spawnPos = new Vector3(-3, 5, 8);
    private PlayerController player;
    private Vector3 spawnPos2;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", startDelay, repeatRate);
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObjects()
    {
        Vector3 spawnPos2 = new Vector3(Random.Range(-5, 1), 5, Random.Range(0, 4));
        int index = Random.Range(0, objectsPrefabs.Length);

        Instantiate(objectsPrefabs[index], spawnPos2, objectsPrefabs[index].transform.rotation);
    }


}
