using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTheAnimals : MonoBehaviour
{
    public float speed = 40;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this moves the animals forwards
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
