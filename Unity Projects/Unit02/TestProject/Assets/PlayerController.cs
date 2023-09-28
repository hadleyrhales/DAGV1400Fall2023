using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 5f;
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
        
        moveDirection.y = moveDirection.y - gravity * Time.deltaTime;

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
        }
        
        moveDirection = new Vector3(horizontalInput, moveDirection.y, verticalInput);
        transform.Translate(moveDirection * moveSpeed);

        controller.Move(moveDirection * Time.deltaTime);
        
    }
}
