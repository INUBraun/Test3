using UnityEngine;
using System.Collections;

public class CharacterMove : MonoBehaviour
{
    CharacterController characterController = null;

    public Transform cameraTransform;
    public float moveSpeed = 10.0f;

    public float jumpSpeed = 10.0f;
    public float gravity = -20.0f;

    float yVelocity = 0.0f;

    int count_jump = 0;
    float jump_gauge = 10;
    float jump_gravity = -2.0f;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void OnCollisionEnter(Collision other)
    {
        //Debug.Log(other);
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
   
        Vector3 moveDirection = new Vector3(x, 0, z);

        moveDirection = cameraTransform.TransformDirection(moveDirection);
        moveDirection *= moveSpeed;

        if (characterController.isGrounded == true)
        {
            yVelocity = 0.0f;
            count_jump = 0;
        }

        if (count_jump < 1)
        {
            if (Input.GetButtonDown("Jump"))
            {
                yVelocity = jumpSpeed;
                count_jump++;
            }
        }

        yVelocity += (gravity * Time.deltaTime);
        moveDirection.y = yVelocity;

        characterController.Move(moveDirection * Time.deltaTime);
    }


}
