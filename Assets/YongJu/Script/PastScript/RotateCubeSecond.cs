using UnityEngine;
using System.Collections;

public class RotateCubeSecond : MonoBehaviour
{
    public GameObject[] mapCube = new GameObject[27];   //배열로 맵 연결
    public GameObject[] rotateCube = new GameObject[9];
    bool isRotate = false;

    void Start()
    {

    }

    void Update()
    {
        if (isRotate == true)
        {
            isRotate = false;
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            int rCubeCount = 0;
            for (int i = 0; i < 27; i++)
            {
                if ((transform.position.x - mapCube[i].transform.position.x) > 0)
                {// 중심보다 왼쪽에 있을 경우, 자식으로 설정
                    rotateCube[rCubeCount] = mapCube[i];
                    rotateCube[rCubeCount].transform.parent = gameObject.transform;
                    rCubeCount++;
                }
            }

            isRotate = true;
        }
    }

}
