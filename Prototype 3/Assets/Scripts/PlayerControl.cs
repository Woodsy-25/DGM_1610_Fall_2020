using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    private RigidBody playerRb;
    public float jumpForce = 500;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<RigidBody>();
        playerRb.AddForce(Vector3 * jumpForce);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
