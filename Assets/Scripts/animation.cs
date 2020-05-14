using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    Animator anim;
    public Animator charAnimation;
    private CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        controller = GetComponentInParent<CharacterController>();
    }
    
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (charAnimation.GetBool("isWalk") == false)
            {
                charAnimation.SetBool("isJump", true);
                charAnimation.SetBool("isStand", false);
            } else if(charAnimation.GetBool("isWalk") == true)
            {
                charAnimation.SetBool("isJumpWalk", true);
                charAnimation.SetBool("isWalk", false);
            }

        }

        if (Input.GetButtonDown("Horizontal"))
        {
            charAnimation.SetBool("isWalk", true);
            charAnimation.SetBool("isStand", false);
        }

        if (controller.isGrounded)
        {
            if (charAnimation.GetBool("isWalk") == false)
            {
                if (charAnimation.GetBool("isJumpWalk") == true)
                {
                    charAnimation.SetBool("isJumpWalk", false);
                    charAnimation.SetBool("isWalk", true);
                    charAnimation.SetBool("isStand", false);
                }
                else
                {
                    charAnimation.SetBool("isJump", false);
                    charAnimation.SetBool("isStand", true);
                }
            } else if(charAnimation.GetBool("isWalk") == true)
            {
                charAnimation.SetBool("isJump", false);
                charAnimation.SetBool("isWalk", true);
            }
        }

        if (Input.GetButtonUp("Horizontal"))
        {
            charAnimation.SetBool("isStand", true);
            charAnimation.SetBool("isWalk", false);
        }

    }
}
