﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);

    private float startDelay = 2;
    private float repeatRate = 2;

    private PlayerControl playerControlScript;

    // Start is called before the first frame update
    void Start()
    {
        //sets up the obstacle spawning
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControlScript = GameObject.Find("Player").GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void SpawnObstacle()
    {
        //using the playerControl script to see if the player has failed or not to know to keep spawning or not
        if (playerControlScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }
}
