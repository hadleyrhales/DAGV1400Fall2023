using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float jumpForce = 2.5f;
    [SerializeField] private float gravity = 9.81f;

    private CharacterController controller;
    private Vector3 moveDirection;
    private bool isJumping;
    
    
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        // set gravity
        moveDirection.y -= gravity * Time.deltaTime;
        
        // jumping mechanic
        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            isJumping = true;
        }
        else
        {
            isJumping = false;
        }
        
        if (isJumping == true)
        {
            moveDirection.y = jumpForce;
            isJumping = false;
        }else if (isJumping == false)
        {
            moveDirection.y -= gravity * Time.deltaTime;
        }
        
        //set scale
        Vector3 originalScale = new Vector3(1, 1, 1);
        
        //crouch mechanic
        if (Input.GetButtonDown("Fire1") || Input.GetButton("Fire1"))
        {
            Vector3 crouchScale = new Vector3(originalScale.x, .5f, originalScale.z);
            gameObject.transform.localScale = crouchScale;
            moveSpeed = 3f;
            // trying to disable jumping
            if (Input.GetButtonDown("Jump") && controller.isGrounded)
            {
                moveDirection.y -= gravity * Time.deltaTime;
            }
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            gameObject.transform.localScale = originalScale;
            moveSpeed = 10f;
        }
        
        //sprinting mechanic
        if (Input.GetButtonDown("Fire3") || Input.GetButton("Fire3"))
        {
            moveSpeed = 15f;
        }else if (Input.GetButtonUp("Fire3"))
        {
            moveSpeed = 10;
        }
        
        //rotation mechanic
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButton(0))
        {
            if (Input.GetAxis("Mouse X") > 0)
            {
                transform.Rotate(Vector3.up, -Input.GetAxis("Mouse X") * 5);
            }else if (Input.GetAxis("Mouse X") < 0)
            {
                transform.Rotate(Vector3.up, -Input.GetAxis("Mouse X") * 5);
            }
        }
        
        moveDirection = new Vector3(horizontalInput, moveDirection.y, verticalInput);
        transform.Translate(moveDirection * moveSpeed);

        controller.Move(moveDirection * Time.deltaTime * moveSpeed);
        
    }
}
