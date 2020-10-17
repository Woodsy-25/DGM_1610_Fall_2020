using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // the game object that are connected to this script (all animals and food objects) will destroy eachother when they collide
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
