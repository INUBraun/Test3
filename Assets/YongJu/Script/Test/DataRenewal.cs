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
        // 좌측 회전 z 90 / 우측 회전 z -90
        int cPosition = DataSingleton.Singleton().currnetPosition;
        int tmp;
        if (isX)
        {
            if(DataSingleton.Singleton().currentRotateSetX == 0)
            {
                if(countZ> 0)
                {
                    tmp = DataSingleton.Singleton().nowRotateData[1].cubeNum;
                    DataSingleton.Singleton().nowRotateData[1].cubeNum = DataSingleton.Singleton().nowRotateData[14].cubeNum;
                    DataSingleton.Singleton().nowRotateData[14].cubeNum = DataSingleton.Singleton().nowRotateData[19].cubeNum;
                    DataSingleton.Singleton().nowRotateData[19].cubeNum = DataSingleton.Singleton().nowRotateData[12].cubeNum;
                    DataSingleton.Singleton().nowRotateData[12].cubeNum = tmp;
                    tmp = DataSingleton.Singleton().nowRotateData[0].cubeNum = DataSingleton.Singleton().nowRotateData[0].cubeNum;
                    DataSingleton.Singleton().nowRotateData[0].cubeNum = DataSingleton.Singleton().nowRotateData[2].cubeNum;
                    DataSingleton.Singleton().nowRotateData[2].cubeNum = DataSingleton.Singleton().nowRotateData[20].cubeNum;
                    DataSingleton.Singleton().nowRotateData[20].cubeNum = DataSingleton.Singleton().nowRotateData[18].cubeNum;
                    DataSingleton.Singleton().nowRotateData[18].cubeNum = tmp;

                }
                else
                {

                }
            }
            else if (DataSingleton.Singleton().currentRotateSetX == 1)
            {
                if (countZ > 0)
                {

                }
                else
                {

                }
            }
            else
            {
                if (countZ > 0)
                {

                }
                else
                {

                }
            }
        }
        else if (isZ)
        {

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
            DataSingleton.Singleton().nowRotateData[i].countRotateX = 0;
            DataSingleton.Singleton().nowRotateData[i].countRotateZ = 0;

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

        //for (int i = 0; i < 3; i++)
        //{
        //    DataSingleton.Singleton().nowRotateSetX[i] = new rotateCubeStruct[9];
        //    DataSingleton.Singleton().nowRotateSetZ[i] = new rotateCubeStruct[9];
        //
        //    for (int j = 0; j < 3; j++)
        //    {
        //        DataSingleton.Singleton().nowRotateSetX[i][j * 3 + 0] = DataSingleton.Singleton().nowRotateData[i * 3 + j * 9 + 0];
        //        DataSingleton.Singleton().nowRotateSetX[i][j * 3 + 1] = DataSingleton.Singleton().nowRotateData[i * 3 + j * 9 + 1];
        //        DataSingleton.Singleton().nowRotateSetX[i][j * 3 + 2] = DataSingleton.Singleton().nowRotateData[i * 3 + j * 9 + 2];
        //
        //        DataSingleton.Singleton().nowRotateSetZ[i][j * 3 + 0] = DataSingleton.Singleton().nowRotateData[i + j * 9 + 0];
        //        DataSingleton.Singleton().nowRotateSetZ[i][j * 3 + 1] = DataSingleton.Singleton().nowRotateData[i + j * 9 + 3];
        //        DataSingleton.Singleton().nowRotateSetZ[i][j * 3 + 2] = DataSingleton.Singleton().nowRotateData[i + j * 9 + 6];
        //    }
        //}
    }
}
