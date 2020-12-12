using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRb;
    private GameManager gameManager;
    private float minSpeed = 12, maxSpeed = 16, maxSpin = 10, xRange = 4, ySpawn = -6;
    public int pointValue;
    public ParticleSystem explosionPartical;
    
    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

        targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        targetRb.AddTorque(RandomSpin(), RandomSpin(), RandomSpin(), ForceMode.Impulse);

        transform.position = (RandomSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //finds a random force to apply
    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }
    //finds a random spin to apply
    float RandomSpin()
    {
        return Random.Range(-maxSpin, maxSpin);
    }
    //finds a random spawn position
    Vector3 RandomSpawn()
    {
        return new Vector3(Random.Range(-xRange, xRange), ySpawn);
    }
    //destroys objects when they are clicked
    private void OnMouseDown()
    {
        if(gameManager.isGameActive)
        {
            Destroy(gameObject);
            Instantiate(explosionPartical, transform.position, explosionPartical.transform.rotation);
            gameManager.UpdateScore(pointValue);
        }
        
    }
    //destoys objects when they hit the sensor and if its a good object it ends the game
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if(!gameObject.CompareTag("Bad"))
        {
            gameManager.GameOver();
        }
    }

}
