using UnityEngine;
using System.Collections;

public class DataRenewal : MonoBehaviour
{
    void Start()
    {
        //Debug.Log("currentCube = " );
    }

    public void ChangeCube(bool isX, bool isZ, float countX, float countZ)
    {
        // 정면 회전 x 90 / 후면 회전 x -90
        // 좌측면 회전 z 90 / 우측면 회전 z -90
        int cPosition = DataSingleton.Singleton().currnetPosition;
        int tmp;
        int setxz;

        if (isZ)
        {
            setxz = DataSingleton.Singleton().currentRotateSetX;
            if (countZ > 0)
            {
                tmp = DataSingleton.Singleton().nowRotateData[setxz * 3 + 1].cubeNum;
                DataSingleton.Singleton().nowRotateData[setxz * 3 + 1].cubeNum = DataSingleton.Singleton().nowRotateData[setxz * 3 + 11].cubeNum;
                DataSingleton.Singleton().nowRotateData[setxz * 3 + 11].cubeNum = DataSingleton.Singleton().nowRotateData[setxz * 3 + 19].cubeNum;
                DataSingleton.Singleton().nowRotateData[setxz * 3 + 19].cubeNum = DataSingleton.Singleton().nowRotateData[setxz * 3 + 9].cubeNum;
                DataSingleton.Singleton().nowRotateData[setxz * 3 + 9].cubeNum = tmp;
                tmp = DataSingleton.Singleton().nowRotateData[setxz * 3 + 0].cubeNum;
                DataSingleton.Singleton().nowRotateData[setxz * 3 + 0].cubeNum = DataSingleton.Singleton().nowRotateData[setxz * 3 + 2].cubeNum;
                DataSingleton.Singleton().nowRotateData[setxz * 3 + 2].cubeNum = DataSingleton.Singleton().nowRotateData[setxz * 3 + 20].cubeNum;
                DataSingleton.Singleton().nowRotateData[setxz * 3 + 20].cubeNum = DataSingleton.Singleton().nowRotateData[setxz * 3 + 18].cubeNum;
                DataSingleton.Singleton().nowRotateData[setxz * 3 + 18].cubeNum = tmp;
            }
            else
            {
                tmp = DataSingleton.Singleton().nowRotateData[setxz * 3 + 1].cubeNum;
                DataSingleton.Singleton().nowRotateData[setxz * 3 + 1].cubeNum = DataSingleton.Singleton().nowRotateData[setxz * 3 + 9].cubeNum;
                DataSingleton.Singleton().nowRotateData[setxz * 3 + 9].cubeNum = DataSingleton.Singleton().nowRotateData[setxz * 3 + 19].cubeNum;
                DataSingleton.Singleton().nowRotateData[setxz * 3 + 19].cubeNum = DataSingleton.Singleton().nowRotateData[setxz * 3 + 11].cubeNum;
                DataSingleton.Singleton().nowRotateData[setxz * 3 + 11].cubeNum = tmp;
                tmp = DataSingleton.Singleton().nowRotateData[setxz * 3 + 0].cubeNum;
                DataSingleton.Singleton().nowRotateData[setxz * 3 + 0].cubeNum = DataSingleton.Singleton().nowRotateData[setxz * 3 + 18].cubeNum;
                DataSingleton.Singleton().nowRotateData[setxz * 3 + 18].cubeNum = DataSingleton.Singleton().nowRotateData[setxz * 3 + 20].cubeNum;
                DataSingleton.Singleton().nowRotateData[setxz * 3 + 20].cubeNum = DataSingleton.Singleton().nowRotateData[setxz * 3 + 2].cubeNum;
                DataSingleton.Singleton().nowRotateData[setxz * 3 + 2].cubeNum = tmp;
            }
        }
        else if (isX)
        {
            setxz = DataSingleton.Singleton().currentRotateSetX;
            if (countX > 0)
            {
                tmp = DataSingleton.Singleton().nowRotateData[setxz + 3].cubeNum;
                DataSingleton.Singleton().nowRotateData[setxz + 3].cubeNum = DataSingleton.Singleton().nowRotateData[setxz + 15].cubeNum;
                DataSingleton.Singleton().nowRotateData[setxz + 15].cubeNum = DataSingleton.Singleton().nowRotateData[setxz + 21].cubeNum;
                DataSingleton.Singleton().nowRotateData[setxz + 21].cubeNum = DataSingleton.Singleton().nowRotateData[setxz + 9].cubeNum;
                DataSingleton.Singleton().nowRotateData[setxz + 9].cubeNum = tmp;
                tmp = DataSingleton.Singleton().nowRotateData[setxz + 0].cubeNum;
                DataSingleton.Singleton().nowRotateData[setxz + 0].cubeNum = DataSingleton.Singleton().nowRotateData[setxz + 6].cubeNum;
                DataSingleton.Singleton().nowRotateData[setxz + 6].cubeNum = DataSingleton.Singleton().nowRotateData[setxz + 24].cubeNum;
                DataSingleton.Singleton().nowRotateData[setxz + 24].cubeNum = DataSingleton.Singleton().nowRotateData[setxz + 18].cubeNum;
                DataSingleton.Singleton().nowRotateData[setxz + 18].cubeNum = tmp;
            }
            else
            {
                tmp = DataSingleton.Singleton().nowRotateData[setxz + 3].cubeNum;
                DataSingleton.Singleton().nowRotateData[setxz + 3].cubeNum = DataSingleton.Singleton().nowRotateData[setxz + 9].cubeNum;
                DataSingleton.Singleton().nowRotateData[setxz + 9].cubeNum = DataSingleton.Singleton().nowRotateData[setxz + 21].cubeNum;
                DataSingleton.Singleton().nowRotateData[setxz + 21].cubeNum = DataSingleton.Singleton().nowRotateData[setxz + 15].cubeNum;
                DataSingleton.Singleton().nowRotateData[setxz + 15].cubeNum = tmp;
                tmp = DataSingleton.Singleton().nowRotateData[setxz + 0].cubeNum;
                DataSingleton.Singleton().nowRotateData[setxz + 0].cubeNum = DataSingleton.Singleton().nowRotateData[setxz + 18].cubeNum;
                DataSingleton.Singleton().nowRotateData[setxz + 18].cubeNum = DataSingleton.Singleton().nowRotateData[setxz + 24].cubeNum;
                DataSingleton.Singleton().nowRotateData[setxz + 24].cubeNum = DataSingleton.Singleton().nowRotateData[setxz + 6].cubeNum;
                DataSingleton.Singleton().nowRotateData[setxz + 6].cubeNum = tmp;
            }
        }
    }

    public void RenewalData()
    {

    }

    // 데이터 초기화 함수
    // 현재는 startcube에서 버튼을 클릭하면 활성화 되게 해놓은 상태   
    public void InitializeData()
    {
        DataSingleton.Singleton().currentCube = 13;         // 큐브의 방 상태넘버값
        DataSingleton.Singleton().currnetPosition = 13;     // 큐브의 절대적 위치값, 배열 넘버

        int cPosition = DataSingleton.Singleton().currnetPosition;

        if (((cPosition % 9) / 3) == 0)
        {
            DataSingleton.Singleton().currentRotateSetX = 0;
        }
        else if (((cPosition % 9) / 3) == 1)
        {
            DataSingleton.Singleton().currentRotateSetX = 1;
        }
        else
        {
            DataSingleton.Singleton().currentRotateSetX = 2;
        }

        if (((cPosition % 9) % 3) == 0)
        {
            DataSingleton.Singleton().currentRotateSetZ = 0;
        }
        else if (((cPosition % 9) % 3) == 1)
        {
            DataSingleton.Singleton().currentRotateSetZ = 1;
        }
        else
        {
            DataSingleton.Singleton().currentRotateSetZ = 2;
        }

        for (int i = 0; i < 27; i++)
        {
            DataSingleton.Singleton().nowRotateData[i].cubeNum = i;
            DataSingleton.Singleton().nowStatusData[i].countRotateX = 0;
            DataSingleton.Singleton().nowStatusData[i].countRotateZ = 0;

            if ((i - 9) < 0)
            {
                DataSingleton.Singleton().nowRotateData[i].upCubeNum = -1;
            }
            else
            {
                DataSingleton.Singleton().nowRotateData[i].upCubeNum = i - 9;
            }

            if ((i + 9) > 26)
            {
                DataSingleton.Singleton().nowRotateData[i].downCubeNum = -1;
            }
            else
            {
                DataSingleton.Singleton().nowRotateData[i].downCubeNum = i + 9;
            }

            if ((i % 3) == 0)
            {
                DataSingleton.Singleton().nowRotateData[i].leftCubeNum = -1;
            }
            else
            {
                DataSingleton.Singleton().nowRotateData[i].leftCubeNum = i - 1;
            }

            if ((i - 2) % 3 == 0)
            {
                DataSingleton.Singleton().nowRotateData[i].rightCubeNum = -1;
            }
            else
            {
                DataSingleton.Singleton().nowRotateData[i].rightCubeNum = i + 1;
            }

            if ((i % 9) >= 0 && (i % 9) <= 2)
            {
                DataSingleton.Singleton().nowRotateData[i].forwardCubeNum = -1;
            }
            else
            {
                DataSingleton.Singleton().nowRotateData[i].forwardCubeNum = i - 3;
            }

            if ((i % 9) >= 6 && (i % 9) <= 8)
            {
                DataSingleton.Singleton().nowRotateData[i].backCubeNum = -1;
            }
            else
            {
                DataSingleton.Singleton().nowRotateData[i].backCubeNum = i + 3;
            }
        }
    }
}
