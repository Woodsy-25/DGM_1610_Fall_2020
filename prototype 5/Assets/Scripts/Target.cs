using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRb;

    private float minSpeed = 12, maxSpeed = 16, maxTorque = 10, xRange = 4, ySpawnPos = -6;

    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        targetRb.AddTorque(Random.Range(-maxTorque, maxTorque), Random.Range(-maxTorque, maxTorque), Random.Range(-maxTorque, maxTorque));
        transform.position = new Vector3(Random.Range(-xRange, xRange), -ySpawnPos, 0);
    }

    Vector3 RandomForce()
    {
        retrun Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    float RandomTorque()
    {

    }

    Vector3 RandomSpawnPos()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
