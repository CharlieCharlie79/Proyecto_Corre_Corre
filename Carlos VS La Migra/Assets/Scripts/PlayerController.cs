﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public float jumpforce;
    public bool isGrounded = false;
    public Animator animator;

    private Rigidbody2D rb2d;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Jump();    
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * speed;
            
        if(movement.x > 0)
        {
            animator.SetFloat("Speed", 1);
          
        }

        else if(movement.x > -1)
        {
            animator.SetFloat("Speed", -1);
        }

        else if (movement.x < 1)
        {
            animator.SetFloat("Speed", 0);         
        }
    }

        void Jump()
    {
        if(Input.GetButtonDown("Jump") && isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpforce), ForceMode2D.Impulse);
            if (isGrounded == true)
            {
                animator.SetBool("IsJumping", true);                      
            }
        
        }

        //else if (Input.GetButtonDown("Jump") && isGrounded == false)
        else if (isGrounded == false)
        {
           // gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 0f), ForceMode2D.Impulse);
            if (isGrounded == false && speed > 0.1f)
            {
                animator.SetBool("IsJumping", false);
            }

        }
    }
}