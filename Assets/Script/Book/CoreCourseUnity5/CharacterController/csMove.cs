using UnityEngine;
using System.Collections;

public class csMove : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float rotSpeed = 120.0f;

    void Update()
    {
        float amtMove = moveSpeed * Time.deltaTime;
        float amtRot = rotSpeed * Time.deltaTime;

        float ver = Input.GetAxis("Vertical");
        float ang = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * ver * amtMove);
        transform.Rotate(Vector3.up * ang * amtRot);
    }

}
