using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float upperBound = 25;
    private float lowerBound = -10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   
        // when the food object reaches the top boundry it will be destroyed
        if (transform.position.z > upperBound)
        {
            Destroy(gameObject);
        }

        // if the animals reach the boundry at the bottom they will be destroyed and log it
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
