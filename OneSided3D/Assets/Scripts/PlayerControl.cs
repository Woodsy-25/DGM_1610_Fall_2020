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
    private GameManager gameManager;
    public AudioClip bounce;
    private AudioSource playersAudio;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        playersAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.isGameActive)
        {
            //takes care of the player movement
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");

            playerRb.AddForce(transform.right * Time.deltaTime * speed * horizontalInput);
            playerRb.AddForce(transform.forward * Time.deltaTime * speed * verticalInput);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        playersAudio.PlayOneShot(bounce, 1.0f);
    }
}
