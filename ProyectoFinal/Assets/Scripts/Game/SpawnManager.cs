using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Prefabs;
    private float spawnRangeX = 15;
    private float spawnPosZ = 20;
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
        do
        {
            float spawnX = Random.Range(-spawnRangeX, spawnRangeX);
            spawnPos = new Vector3(spawnX, 0, spawnPosZ);
        } while (Physics.CheckSphere(spawnPos, 3.0f));

        int animalIndex = Random.Range(0, Prefabs.Length);
        Instantiate(Prefabs[animalIndex], spawnPos,
                    Prefabs[animalIndex].transform.rotation);
    }
}
