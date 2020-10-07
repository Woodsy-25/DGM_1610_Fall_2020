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
        if(transform.position.z > upperBound)
        {
            Destroy(gameObject);
        }

        else if(transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
