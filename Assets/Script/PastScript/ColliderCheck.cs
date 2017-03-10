using UnityEngine;
using System.Collections;

public class ColliderCheck : MonoBehaviour
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

    bool isRotateKEY = false;

    Quaternion baseRotation;

    bool isRangeIN = false;
    GameObject cubeInPlayer;

    bool isRotateNow = false;

   public float rotateSpeed = 0.25f;
    void Start()
    {
        baseRotation = rotateManager.transform.rotation;
    }

    void CheckPlayerInCube()
    {
        if (cubeInPlayer != null)
        {
            if (cubeInPlayer.transform.position.x + 6 < this.transform.position.x)
                isRangeIN = true;
            else if (cubeInPlayer.transform.position.x - 6 > this.transform.position.x)
                isRangeIN = true;
            else if (cubeInPlayer.transform.position.z + 6 < this.transform.position.z)
                isRangeIN = true;
            else if (cubeInPlayer.transform.position.z - 6 > this.transform.position.z)
                isRangeIN = true;
            else
                isRangeIN = false;
        }
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        cubeInPlayer = hit.transform.parent.gameObject;

        if (readyRotate == false && isRotateNow == false)
        {
            rinkCount = 0;

            if ((hit.normal.z == 1) || (hit.normal.z == -1))
            {
                //Debug.Log(hit.normal + " --- " + isRotateX);
                if (hit.normal.z == 1)
                    rotateXaxis = -1;
                else if (hit.normal.z == -1)
                    rotateXaxis = 1;

                for (int i = 0; i < 27; i++)
                {
                    Debug.Log("x" + hit.normal + "--- " + isRotateZ + "---" + rinkCount);
                    if ((hit.transform.position.x + 5 > mapCube[i].transform.position.x) && (hit.transform.position.x - 5 < mapCube[i].transform.position.x))
                    {
                        rotateCube[rinkCount] = mapCube[i];
                        rotateCube[rinkCount].transform.parent = rotateManager.transform;
                        rinkCount++;
                        if (rinkCount == 9)
                        {
                            isRotateX = true;
                            readyRotate = true;
                            Debug.Log(isRotateX);
                            break;
                        }
                    }
                }
            }

            if ((hit.normal.x == 1) || (hit.normal.x == -1))
            {
                //Debug.Log(hit.normal + " --- " + isRotateZ);
                if (hit.normal.x == 1)
                    rotateZaxis = -1;
                else if (hit.normal.x == -1)
                    rotateZaxis = 1;

                for (int i = 0; i < 27; i++)
                {
                    Debug.Log("z" + hit.normal + "--- " + isRotateZ + "---" + rinkCount);
                    if ((hit.transform.position.z + 5 > mapCube[i].transform.position.z) && (hit.transform.position.z - 5 < mapCube[i].transform.position.z))
                    {
                        rotateCube[rinkCount] = mapCube[i];
                        rotateCube[rinkCount].transform.parent = rotateManager.transform;
                        rinkCount++;
                        if (rinkCount == 9)
                        {
                            isRotateZ = true;
                            readyRotate = true;
                            Debug.Log(isRotateZ);
                            break;
                        }
                    }
                }
            }
        }
    }
//
   

    void Update()
    {
        // 플레이어가 벽에 가까이(범위 안에) 있는지 여부를 판단하여 bool값으로 저장
        CheckPlayerInCube();
        //Debug.Log(isRangeIN);

        // 회전을 할 준비(rotateManager에 큐브를 연결)가 되어있지만
        // 플레이어가 벽에서 떨어져있으면 연결을 해제
        // 큐브가 회전 중이지 않을 때, 
        if (isRangeIN == false && readyRotate == true && isRotateNow == false)
        {
            for (int i = 0; i < 9; i++)
            {
                rotateCube[i].transform.parent = rotateManager.transform.parent.transform;
                rotateCube[i] = null;
            }
            readyRotate = false;
            isRotateX = false;
            isRotateZ = false;
        }

        // Z키 입력 여부를 저장
        if (Input.GetKeyDown(KeyCode.Z)  && isRotateNow == false)
        {
            isRotateKEY = true;
        }

        // 회전을 할 준비(rotateManager에 큐브를 연결)가 되어있고
        // Z키를 입력 했으면 회전을 수행
        if (readyRotate == true && isRotateKEY == true)
        {
           
            if (isRotateX == true)
            {
                //  Debug.Log("test");
                rotateManager.transform.Rotate(Vector3.right * Time.deltaTime * 90 * rotateSpeed * rotateXaxis);
                isRotateNow = true;
                if (rotateXaxis == 1)
                {
                    //Debug.Log((rotateManager.transform.rotation.eulerAngles.x - baseRotation.eulerAngles.x) % 90);
                    if (Mathf.Abs(rotateManager.transform.rotation.eulerAngles.x - baseRotation.eulerAngles.x) % 90 > 88)
                    {
                        rotateManager.transform.rotation = Quaternion.AngleAxis(90.0f * rotateXaxis, Vector3.right);

                        for (int i = 0; i < 9; i++)
                        {
                            rotateCube[i].transform.parent = rotateManager.transform.parent.transform;
                            rotateCube[i] = null;
                        }

                        rotateManager.transform.rotation = baseRotation;
                        isRotateX = false;
                        readyRotate = false;
                        isRotateKEY = false;
                        isRotateNow = false;
                    }
                }
                else
                {
                    //Debug.Log((rotateManager.transform.rotation.eulerAngles.x - baseRotation.eulerAngles.x) % 90);
                    if (Mathf.Abs(rotateManager.transform.rotation.eulerAngles.x - baseRotation.eulerAngles.x) % 90 < 2)
                    {
                        rotateManager.transform.rotation = Quaternion.AngleAxis(90.0f * rotateXaxis, Vector3.right);

                        for (int i = 0; i < 9; i++)
                        {
                            rotateCube[i].transform.parent = rotateManager.transform.parent.transform;
                            rotateCube[i] = null;
                        }

                        rotateManager.transform.rotation = baseRotation;
                        isRotateX = false;
                        readyRotate = false;
                        isRotateKEY = false;
                        isRotateNow = false;
                    }
                }

            }
            else if (isRotateZ == true)
            {
                rotateManager.transform.Rotate(Vector3.back * Time.deltaTime * 90 * rotateSpeed * rotateZaxis);
                isRotateNow = true;
                if (rotateZaxis == 1)
                {
                    Debug.Log((rotateManager.transform.rotation.eulerAngles.z - baseRotation.eulerAngles.z) % 90);
                    if (Mathf.Abs(rotateManager.transform.rotation.eulerAngles.z - baseRotation.eulerAngles.z) % 90 < 2)
                    {
                        rotateManager.transform.rotation = Quaternion.AngleAxis(90.0f * rotateZaxis, Vector3.back);

                        for (int i = 0; i < 9; i++)
                        {
                            rotateCube[i].transform.parent = rotateManager.transform.parent.transform;
                            rotateCube[i] = null;
                        }

                        rotateManager.transform.rotation = baseRotation;
                        isRotateZ = false;
                        readyRotate = false;
                        isRotateKEY = false;
                        isRotateNow = false;
                    }
                }
                else
                {
                    //Debug.Log((rotateManager.transform.rotation.eulerAngles.z - baseRotation.eulerAngles.z) % 90);
                    if (Mathf.Abs(rotateManager.transform.rotation.eulerAngles.z - baseRotation.eulerAngles.z) % 90 > 88)
                    {
                        rotateManager.transform.rotation = Quaternion.AngleAxis(90.0f * rotateZaxis, Vector3.back);

                        for (int i = 0; i < 9; i++)
                        {
                            rotateCube[i].transform.parent = rotateManager.transform.parent.transform;
                            rotateCube[i] = null;
                        }

                        rotateManager.transform.rotation = baseRotation;
                        isRotateZ = false;
                        readyRotate = false;
                        isRotateKEY = false;
                        isRotateNow = false;
                    }
                }
            }
        }
        else
        {
            isRotateKEY = false;
        }
    }
}
