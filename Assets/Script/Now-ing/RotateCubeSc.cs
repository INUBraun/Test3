using UnityEngine;
using System.Collections;

public class RotateCubeSc : MonoBehaviour
{
    RotateManager manager;

    bool isRotate = false;
    Vector3 rotateVector;

    float countEuler = 0.0f;
    Quaternion target;

    void Start()
    {
        manager = GetComponent<RotateManager>();
    }

    void Update()
    {
        isRotate = manager.GetIsRotateGo();

        if(isRotate)
        {
            rotateVector = manager.GetRotateVector();
            Debug.Log(rotateVector);
            countEuler += 90.0f * Time.deltaTime * 0.5f;
            // 방향이 x인지 z인지 + 인지 - 인지 정한뒤에 회전

           
            if (countEuler < 90.0f)
            {
                if (rotateVector.x == 1)
                {
                    target = Quaternion.Euler(countEuler, 0.0f, 0.0f);
                    transform.rotation = target;
                }
                else if (rotateVector.x == -1)
                {
                    target = Quaternion.Euler(-countEuler, 0.0f, 0.0f);
                    transform.rotation = target;
                }
                else if (rotateVector.z == 1)
                {
                    target = Quaternion.Euler(0.0f, 0.0f, countEuler);
                    transform.rotation = target;
                }
                else if (rotateVector.z == -1)
                {
                    target = Quaternion.Euler(0.0f, 0.0f, -countEuler);
                    transform.rotation = target;
                }

            }
            else
            {
                if (rotateVector.x == 1)
                {
                    target = Quaternion.Euler(90.0f, 0.0f, 0.0f);
                }
                else if (rotateVector.x == -1)
                {
                    target = Quaternion.Euler(-90.0f, 0.0f, 0.0f);
                }
               else if (rotateVector.z == 1)
                {
                    target = Quaternion.Euler(0.0f, 0.0f, 90.0f);
                }
                else if (rotateVector.z == -1)
                {
                    target = Quaternion.Euler(0.0f, 0.0f, -90.0f);
                }

                transform.rotation = target;

                isRotate = false;
                manager.SetIsRotateEnd();
                rotateVector = Vector3.zero;
                countEuler = 0;
                transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
            }

        }

    }
}
