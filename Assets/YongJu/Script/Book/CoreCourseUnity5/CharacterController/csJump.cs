﻿using UnityEngine;
using System.Collections;

public class csJump : MonoBehaviour
{
    float gravity = -20.0f;
    float jumpSpeed = 10.0f;
    Vector3 velocity;

    CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        velocity = new Vector3(0, 0, 0);
    }

    void Update()
    {
        float y = transform.position.y;
        if(y<1)
        {
            gameObject.transform.position = new Vector3(0.0f, 1.1f, 0.0f);
        }
        
        //  캐릭터가 땅에 닿아 있는지 체크
        if (controller.isGrounded)
        {
            if(Input.GetButtonDown("Jump"))
            {
                velocity.y = jumpSpeed;
            }
        }

        velocity.y += (gravity * Time.deltaTime);

        controller.Move(velocity * Time.deltaTime);
    }
}
