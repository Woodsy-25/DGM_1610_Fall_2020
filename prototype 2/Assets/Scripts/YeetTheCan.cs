using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YeetTheCan : MonoBehaviour
{
    public float speed = 40;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this moves the can forward but needs to use 'Vector3.up' because of how the can is rotated
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
}
