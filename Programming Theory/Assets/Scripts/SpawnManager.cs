using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animals;
    private float spawnRange = 5f;
    private float startDelay = 2.0f;
    private float animalSpawnTime = 1f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimals", startDelay, animalSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnAnimals()
    {
        float randomZ = Random.Range(-spawnRange, spawnRange);
        int randomIndex = Random.Range(0, animals.Length);

        Vector3 spawnPos = new Vector3(-12, 2, randomZ);

        Instantiate(animals[randomIndex], spawnPos, animals[randomIndex].gameObject.transform.rotation);
    }
}
