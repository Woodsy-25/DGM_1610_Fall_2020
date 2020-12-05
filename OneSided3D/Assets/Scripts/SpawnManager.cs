using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject pillarPrefab;
    private float spawnRange = 23;
    public int pillarCount = 20;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < pillarCount; i++)
        {
            Instantiate(pillarPrefab, GenSpawnPos(), pillarPrefab.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private Vector3 GenSpawnPos()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 1, spawnPosZ);
        return randomPos;        
    }
}
