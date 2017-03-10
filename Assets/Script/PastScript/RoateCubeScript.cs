using UnityEngine;
using System.Collections;

public class RoateCubeScript : MonoBehaviour
{
    public GameObject[] mapCube = new GameObject[27];
    GameObject[] rotateCube = new GameObject[9];

   public GameObject[] leftCube = new GameObject[9];
    public GameObject[] centerCube = new GameObject[9];
    public GameObject[] rightCube = new GameObject[9];

    bool isRotate = false;
    bool hasParent = false;
  
    Quaternion tmpVector;
    Quaternion zeroQuaternion;

    int rotateDirection = 1;

    ROTATEOBJ rotateObject = ROTATEOBJ.CENTER;
    ROTATEAXIS rotateAxis = ROTATEAXIS.XAXIS;

    public enum ROTATEAXIS
    {
        XAXIS = 0,
        YAXIS,
        ZAXIS
    }
    public enum ROTATEOBJ
    {
        LEFT = -1,
        CENTER = 0,
        RIGHT = 1
    }

    void Start()
    {
        zeroQuaternion = transform.rotation;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && !isRotate)
        {
            rotateAxis = ROTATEAXIS.XAXIS;
            int ra = Random.Range(-1, 2);

            if (ra == -1)
                rotateObject = ROTATEOBJ.LEFT;
            else if (ra == 0)
                rotateObject = ROTATEOBJ.CENTER;
            else
                rotateObject = ROTATEOBJ.RIGHT;

            int i_left = 0;
            int i_center = 0;
            int i_right = 0;

            for (int i = 0; i < 27; i++)        // 위치별로 배열에 저장
            {
                float differ = transform.position.x - mapCube[i].transform.position.x;

                if (differ > 5) //아래 9개 큐브
                {
                    leftCube[i_left] = mapCube[i];
                    i_left++;
                }
                else if (differ < -5) //아래 9개 큐브
                {
                    rightCube[i_right] = mapCube[i];
                    i_right++;
                }
                else
                {
                    centerCube[i_center] = mapCube[i];
                    i_center++;
                }
            }

            for (int j = 0; j < 9; j++)
            {
                if (rotateObject == ROTATEOBJ.LEFT)
                {
                    rotateCube[j] = leftCube[j];
                    rotateCube[j].transform.parent = gameObject.transform;
                }
                else if (rotateObject == ROTATEOBJ.CENTER)
                {
                    rotateCube[j] = centerCube[j];
                    rotateCube[j].transform.parent = gameObject.transform;
                }
                else if (rotateObject == ROTATEOBJ.RIGHT)
                {
                    rotateCube[j] = rightCube[j];
                    rotateCube[j].transform.parent = gameObject.transform;
                }
            }

            tmpVector = transform.rotation;
            Debug.Log("test");
            isRotate = true;
            hasParent = true;
        }

        if (Input.GetKeyDown(KeyCode.Y) && !isRotate )
        {
            rotateAxis = ROTATEAXIS.YAXIS;
            int ra = Random.Range(-1, 2);
           
            if (ra == -1)
                rotateObject = ROTATEOBJ.LEFT;
            else if (ra == 0)
                rotateObject = ROTATEOBJ.CENTER;
            else
                rotateObject = ROTATEOBJ.RIGHT;

            int i_left = 0;
            int i_center = 0;
            int i_right = 0;

            for (int i = 0; i < 27; i++)        // 위치별로 배열에 저장
            {
                float differ = transform.position.y - mapCube[i].transform.position.y;

                if (differ > 5) //아래 9개 큐브
                {
                    leftCube[i_left] = mapCube[i];
                    i_left++;
                }
                else if (differ < -5) //아래 9개 큐브
                {
                    rightCube[i_right] = mapCube[i];
                    i_right++;
                }
                else
                {
                    centerCube[i_center] = mapCube[i];
                    i_center++;
                }
            }

            for (int j = 0; j < 9; j++)
            {
                if (rotateObject == ROTATEOBJ.LEFT)
                {   
                    rotateCube[j] = leftCube[j];
                    rotateCube[j].transform.parent = gameObject.transform;
                }
                else if (rotateObject == ROTATEOBJ.CENTER)
                {
                    rotateCube[j] = centerCube[j];
                    rotateCube[j].transform.parent = gameObject.transform;
                }
                else if (rotateObject == ROTATEOBJ.RIGHT)
                {
                    rotateCube[j] = rightCube[j];
                    rotateCube[j].transform.parent = gameObject.transform;
                }
            }

            tmpVector = transform.rotation;
            
            isRotate = true;
            hasParent = true;
        }

        if (Input.GetKeyDown(KeyCode.Z) && !isRotate)
        {
            rotateAxis = ROTATEAXIS.ZAXIS;
            int ra = Random.Range(-1, 2);

            if (ra == -1)
                rotateObject = ROTATEOBJ.LEFT;
            else if (ra == 0)
                rotateObject = ROTATEOBJ.CENTER;
            else
                rotateObject = ROTATEOBJ.RIGHT;

            int i_left = 0;
            int i_center = 0;
            int i_right = 0;

            for (int i = 0; i < 27; i++)        // 위치별로 배열에 저장
            {
                float differ = transform.position.z - mapCube[i].transform.position.z;

                if (differ > 5) //아래 9개 큐브
                {
                    leftCube[i_left] = mapCube[i];
                    i_left++;
                }
                else if (differ < -5) //아래 9개 큐브
                {
                    rightCube[i_right] = mapCube[i];
                    i_right++;
                }
                else
                {
                    centerCube[i_center] = mapCube[i];
                    i_center++;
                }
            }

            for (int j = 0; j < 9; j++)
            {
                if (rotateObject == ROTATEOBJ.LEFT)
                {
                    rotateCube[j] = leftCube[j];
                    rotateCube[j].transform.parent = gameObject.transform;
                }
                else if (rotateObject == ROTATEOBJ.CENTER)
                {
                    rotateCube[j] = centerCube[j];
                    rotateCube[j].transform.parent = gameObject.transform;
                }
                else if (rotateObject == ROTATEOBJ.RIGHT)
                {
                    rotateCube[j] = rightCube[j];
                    rotateCube[j].transform.parent = gameObject.transform;
                }
            }

            tmpVector = transform.rotation;

            isRotate = true;
            hasParent = true;
        }

        if (isRotate)
        {
            switch (rotateAxis)
            {
                case ROTATEAXIS.XAXIS:
                    {
                        transform.Rotate(Vector3.right * Mathf.Clamp(1.0f, 0, 90));
                        if (Mathf.Abs(transform.rotation.eulerAngles.x - tmpVector.eulerAngles.x) > 89.9)
                        {
                            for(int k = 0; k<9;  k++)
                            {
                                rotateCube[k].GetComponent<CubeStateScript>().rotateX++;
                            }
                            isRotate = false;
                        }
                        break;
                    }
                case ROTATEAXIS.YAXIS:
                    {
                        transform.Rotate(Vector3.up * Mathf.Clamp(1.0f, 0, 90));
                        if (Mathf.Abs(transform.rotation.eulerAngles.y - tmpVector.eulerAngles.y) > 90)
                        {
                            for (int k = 0; k < 9; k++)
                            {
                                rotateCube[k].GetComponent<CubeStateScript>().rotateY++;
                            }
                            isRotate = false;
                        }
                        break;
                    }
                case ROTATEAXIS.ZAXIS:
                    {
                        transform.Rotate(Vector3.forward * Mathf.Clamp(1.0f, 0, 90));
                        if (Mathf.Abs(transform.rotation.eulerAngles.z - tmpVector.eulerAngles.z) > 90)
                        {
                            for (int k = 0; k < 9; k++)
                            {
                                rotateCube[k].GetComponent<CubeStateScript>().rotateZ++;
                            }
                            isRotate = false;
                        }
                        break;
                    }
            }    
        }
        else
        {   // 계층 구조 해제
            if (hasParent)
            {
                for (int i = 0; i < rotateCube.Length; i++)
                {
                    rotateCube[i].transform.parent = transform.parent;
                }
                hasParent = false;
                transform.rotation = zeroQuaternion;
                for(int l = 0; l < 9; l++)
                {
                    rotateCube[l].GetComponent<CubeStateScript>().RangeCube();
                    Debug.Log(l + "==" + rotateCube[l].GetComponent<CubeStateScript>().rotateX + " " + rotateCube[l].GetComponent<CubeStateScript>().rotateY + " " + rotateCube[l].GetComponent<CubeStateScript>().rotateZ);
                }
            }
        }
    }
}
