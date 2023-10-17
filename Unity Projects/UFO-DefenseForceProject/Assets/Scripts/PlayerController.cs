using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // player movement
    public float horizontalInput;
    public float speed;
    public float xRange;
   
    // item inventory
    public GameObject[] inventory = new GameObject[1];

    // player-enabled projectile
    public Transform blaster;
    public GameObject lazerBolt;

    // access to GameManager
    public GameManager gameManager;

    void Start()
    {
        // allows reference to GameManager script component
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // set horizontalInput to get values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");
        // makes player move left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        
        // restricts player movement to be within set bounds
        // left side
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        // right side
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // if space bar is pressed fires lazerBolt
        // second condition (gameManager bool) prevents lazer bolt from being fired after game has ended
        if (Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false)
        {
            // creates lazerBolt at blaster position while maintaining the bolt's rotation
            Instantiate(lazerBolt, blaster.transform.position, lazerBolt.transform.rotation);
        }
    }
    
    // checks if object is an item
        // if it is, it will store item in inventory array
    // deletes any object that has a trigger when object hits player
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            inventory[0] = other.gameObject;
            for (int i = 0; i < inventory.Length; i++)
            {
                Debug.Log($"{inventory[i]}");
            }
        }
        Destroy(other.gameObject);
    }
}
