using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float spawnRangeX = 16;
    public float spawnRangeZ = 20;
    public float startDelay = 2;
    public float spawnTime = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        // this will spawn the animals in at random times after a delay from start
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        // allows the player to spawn in animals if wanted
        if(Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal();
        }
    }

    // method that will randomly spawn in animals
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[0].transform.rotation);
    }
}
