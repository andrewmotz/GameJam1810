using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public KeyCode RightAxis = KeyCode.D;
    public KeyCode LeftAxis = KeyCode.A;
    public KeyCode FallKey = KeyCode.S;
    public float fallMultiplyer = 2.0f;
    public string CrouchKey = "C";
    public KeyCode JumpKey = KeyCode.Space;
    public Animator animator;
    public Rigidbody2D rigidbody2d;

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
            //Right movement
            horizontalMove = 1 * runSpeed;
            animator.SetTrigger("walking");
            //Check for accelerated and right fall
            if (Input.GetKey(FallKey))
            {
                rigidbody2d.gravityScale = fallMultiplyer;
            }

        }
        else if (Input.GetKey(LeftAxis))
        {
            //Left movement
            horizontalMove = -1 * runSpeed;
            animator.SetTrigger("walking");
            //Check for accelerated and left fall
            if (Input.GetKey(FallKey))
            {
                rigidbody2d.gravityScale = fallMultiplyer;
            }
        }
        //Straight down accelerated fall
        else if (Input.GetKey(FallKey))
        {
            rigidbody2d.gravityScale = fallMultiplyer;
            animator.SetTrigger("idle");
            horizontalMove = 0;
        }
        //No Keys are pressed
        else
        {
            horizontalMove = 0;
            rigidbody2d.gravityScale = 1.0f;
            animator.SetTrigger("idle");
        }

        if (Input.GetKey(JumpKey))
        {
            jump = true;
        }

        /*
        if (Input.GetButtonDown(CrouchKey))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp(CrouchKey))
        {
            crouch = false;
        }
        */

    }

    void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}