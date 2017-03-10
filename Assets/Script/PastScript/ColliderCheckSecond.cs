using UnityEngine;
using System.Collections;

public class ColliderCheckSecond : MonoBehaviour
{
    public GameObject[] mapCube = new GameObject[27];
    public GameObject[] rotateCube = new GameObject[9];
    public GameObject rotateManager;

    int rinkCount = 0;

    bool readyRotate = false;

    bool isRotateX = false;
    float rotateXaxis = 0;
    bool isRotateY = false;
    float rotateYaxis = 0;
    bool isRotateZ = false;
    float rotateZaxis = 0;

    Quaternion baseRotation;


    void OnTriggerEnter(Collider other)
    {
        // 들어갔을때, 회전 가능 상태로 변경
    
    }

    void OnTriggerExit(Collider other)
    {
        //나갔을 때, 회전 불가능 상태로 변경
       
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        rinkCount = 0;

        if ((hit.normal.x == 1) || (hit.normal.x == -1))
        {
            if (hit.normal.x == 1)
                rotateZaxis = -1;
            else if (hit.normal.x == -1)
                rotateZaxis = 1;

           // for (int i = 0; i < 27; i++)
           // {
           //     if (hit.transform.position.z == mapCube[i].transform.position.z)
           //     {
           //         rotateCube[rinkCount] = mapCube[i];
           //         rinkCount++;
           //         if (rinkCount == 9)
           //         {
           //             isRotateZ = true;
           //             readyRotate = true;
           //             break;
           //         }
           //     }
           // }
        }
        else
            rotateZaxis = 0;

        if (hit.normal.y == 1)
        {
        }
        else if (hit.normal.y == -1)
        { 
        }
        else
        {
        }

        if ((hit.normal.z == 1) || (hit.normal.z == -1))
        {
            if (hit.normal.z == 1)
                rotateXaxis = -1;
            else if (hit.normal.z == -1)
                rotateXaxis = 1;

            //for (int i = 0; i < 27; i++)
            //{
            //    if (hit.transform.position.x == mapCube[i].transform.position.x)
            //    {
            //        rotateCube[rinkCount] = mapCube[i];
            //        rinkCount++;
            //        if (rinkCount == 9)
            //        {
            //            isRotateX = true;
            //            readyRotate = true;
            //            break;
            //        }
            //    }
            //}
        }
        else
            rotateXaxis = 0;
    }

    void Start()
    {
        baseRotation = rotateManager.transform.rotation;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (readyRotate == true)
            {
                for (int i = 0; i < 9; i++)
                {
                    rotateCube[i].transform.parent = rotateManager.transform;
                }
                readyRotate = false;
            }
        }

        if (isRotateX == true)
        {
            rotateManager.transform.Rotate(Vector3.right * Time.deltaTime * 90 * 0.5f * rotateXaxis);

            if (rotateXaxis == 1)
            {
                if (Mathf.Abs(rotateManager.transform.rotation.eulerAngles.x - baseRotation.eulerAngles.x) % 90 > 89)
                {
                    rotateManager.transform.rotation = Quaternion.AngleAxis(90.0f * rotateXaxis, Vector3.right);

                    for (int i = 0; i < 9; i++)
                    {
                        rotateCube[i].transform.parent = rotateManager.transform.parent.transform;
                    }

                    rotateManager.transform.rotation = baseRotation;
                    isRotateX = false;
                }
            }
            else
            {
                if (Mathf.Abs(rotateManager.transform.rotation.eulerAngles.x - baseRotation.eulerAngles.x) % 90 < 1)
                {
                    rotateManager.transform.rotation = Quaternion.AngleAxis(90.0f * rotateXaxis, Vector3.right);

                    for (int i = 0; i < 9; i++)
                    {
                        rotateCube[i].transform.parent = rotateManager.transform.parent.transform;
                    }

                    rotateManager.transform.rotation = baseRotation;
                    isRotateX = false;
                }
            }

        }
        else if (isRotateZ == true)
        {
            rotateManager.transform.Rotate(Vector3.back * Time.deltaTime * 90 * 0.5f * rotateZaxis);

            if (rotateZaxis == 1)
            {
                if (Mathf.Abs(rotateManager.transform.rotation.eulerAngles.z - baseRotation.eulerAngles.z) % 90 < 1)
                {
                    rotateManager.transform.rotation = Quaternion.AngleAxis(90.0f * rotateZaxis, Vector3.back);

                    for (int i = 0; i < 9; i++)
                    {
                        rotateCube[i].transform.parent = rotateManager.transform.parent.transform;
                    }

                    rotateManager.transform.rotation = baseRotation;
                    isRotateZ = false;
                }
            }
            else
            {
                if (Mathf.Abs(rotateManager.transform.rotation.eulerAngles.z - baseRotation.eulerAngles.z) % 90 > 89)
                {
                    rotateManager.transform.rotation = Quaternion.AngleAxis(90.0f * rotateZaxis, Vector3.back);

                    for (int i = 0; i < 9; i++)
                    {
                        rotateCube[i].transform.parent = rotateManager.transform.parent.transform;
                    }

                    rotateManager.transform.rotation = baseRotation;
                    isRotateZ = false;
                }
            }
        }
    }
}
