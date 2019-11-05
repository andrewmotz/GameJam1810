using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public KeyCode RightAxis = KeyCode.D;
    public KeyCode LeftAxis = KeyCode.A;
    public KeyCode JumpKey = KeyCode.Space;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    // Update is called once per frame
    void Update()
    {

        //horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
       

        if (Input.GetKey(RightAxis))
        {
            horizontalMove = 1 * runSpeed;

        } else if (Input.GetKey(LeftAxis))
        {
            horizontalMove = -1 * runSpeed;

        } else
        {
            horizontalMove = 0;
        }

        if (Input.GetKey(JumpKey))
        {
            jump = true;
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
        
    }

    void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}