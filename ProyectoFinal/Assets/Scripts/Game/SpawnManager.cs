using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
//    x -0.92
//y 9 
//z 0.13
    // Start is called before the first frame update
    public GameObject[] Prefabs;
    public float startDelay = 2;
    public float spawnInterval = 1;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandom", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnRandom()
    {
        Vector3 spawnPos;
            float spawnX = Random.Range(-8.8f, 8.8f);
            spawnPos = new Vector3(spawnX, 9f, 0.13f);
       
        int foodIndex = Random.Range(0, Prefabs.Length);
        Instantiate(Prefabs[foodIndex], spawnPos,
        Prefabs[foodIndex].transform.rotation);
    }
}
