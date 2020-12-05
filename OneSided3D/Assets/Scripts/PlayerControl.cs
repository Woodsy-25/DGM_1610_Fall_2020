using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed = 10.0f;
    public float horizontalInput;
    public float verticalInput;
    public bool isIt = false;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //takes care of the player movement
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(transform.right * Time.deltaTime * speed * horizontalInput);
        playerRb.AddForce(transform.forward * Time.deltaTime * speed * verticalInput);
    }
}
