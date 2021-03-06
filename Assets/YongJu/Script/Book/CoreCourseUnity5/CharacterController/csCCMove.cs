﻿using UnityEngine;
using System.Collections;

public class csCCMove : MonoBehaviour
{

    public float moveSpeed = 5.0f;
    public float rotSpeed = 120.0f;

    CharacterController controller;
    Vector3 moveDirection;

    float jumpSpeed = 10.0f;    // jump speed
    float gravity = 20.0f;       // gravity

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if(controller.isGrounded)
        {
            float amtRot = rotSpeed * Time.deltaTime;

            float ver = Input.GetAxis("Vertical");
            float ang = Input.GetAxis("Horizontal");

            transform.Rotate(Vector3.up * ang * amtRot);

            moveDirection = new Vector3(0, 0, ver * moveSpeed);
            moveDirection = transform.TransformDirection(moveDirection);

            if(Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }

        moveDirection.y -= gravity * Time.deltaTime;

        controller.Move(moveDirection * Time.deltaTime);
    }

}
