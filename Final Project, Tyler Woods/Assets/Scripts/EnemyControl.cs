using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    private GameManager gameManager;
    public float speed = 10.0f;
    private Rigidbody enemyRb;
    private GameObject player, center;
    public bool isIt = true;
    public Transform ObjectA, ObjectB;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

        player = GameObject.Find("Player");
        center = GameObject.Find("center");
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.isGameActive)
        {
            //find the mid point of the player and the center to help tell the enemy where to go
            Vector3 C2A = -ObjectA.position - transform.position;
            Vector3 C2B = ObjectB.position - transform.position;
            Vector3 goTo = new Vector3((C2A.x + C2B.x)/2.0f, (C2A.y + C2B.y)/2.0f, (C2A.z + C2B.z)/2.0f).normalized;

            //tells the enemy to chase the player
            if (isIt == true)
            {
                Vector3 lookDirection = (player.transform.position - transform.position).normalized;

                enemyRb.AddForce(Time.deltaTime * lookDirection * speed);
            }      
            //tells the enemy to run away from the player
            else if (isIt == false)
            {
                enemyRb.AddForce(Time.deltaTime * goTo * speed);
            }
        }
    }

    //switches the enemy from being it and not it when hit
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && isIt == true)
        {
            gameManager.It();
            isIt = false;
        }
        else if (other.CompareTag("Player") && isIt == false)
        {
            gameManager.NotIt();
            isIt = true;
        }
    }
}
