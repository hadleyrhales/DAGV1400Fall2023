using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public GameManager gameManager; // access to GameManager
    public float topBounds = 20.0f;
    public float lowBounds = -10.0f;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); // finds GameManager gameObject and allows access to GameManager script
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject); // destroys gameObject when it passes topBounds
        }
        else if (transform.position.z < lowBounds)
        {
            if (gameObject.CompareTag("Item")) // checks gameObject for Item tag
            {
                Destroy(gameObject); // destroys gameObject when it passes lowBounds
            }
            else // logs "Game Over" in console, destroys gameObject when it passes lowBounds, and ends game
            {
                Debug.Log("Game Over");
                Destroy(gameObject);
                gameManager.isGameOver = true;  
            }
            
        }
    }
}
