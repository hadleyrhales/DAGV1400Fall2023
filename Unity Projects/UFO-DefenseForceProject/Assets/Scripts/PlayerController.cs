using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed;
    public float xRange;

    public Transform blaster;
    public GameObject lazerBolt;

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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // creates lazerBolt at blaster position while maintaining the bolt's rotation
            Instantiate(lazerBolt, blaster.transform.position, lazerBolt.transform.rotation);
        }
    }
    
    // deletes any object that has a trigger when object hits player
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}