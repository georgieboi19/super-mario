using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor : MonoBehaviour
{
    private CharacterController controller;

    public float jumpSpeed = 5f;
    public float speed = 6f;
    public float gravity = 10f;
    private Vector3 moveVector = Vector3.zero;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        moveVector.x = Input.GetAxis("Horizontal") * speed;

        controller.Move(moveVector * Time.deltaTime);
        if (controller.isGrounded) { 
        if (Input.GetButton("Jump"))
        
            moveVector.y = jumpSpeed;
        
        }
        moveVector.y -= gravity * Time.deltaTime;
        controller.Move(moveVector * Time.deltaTime);

     
    }
}
