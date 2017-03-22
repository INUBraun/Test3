using UnityEngine;
using System.Collections;

public class DataSingleton : MonoBehaviour
{
    //  데이터 저장용 싱글톤 기본 생성자 코드 
    public static DataSingleton SingletonInstance = null;

    public static DataSingleton Singleton()
    {
        if (!SingletonInstance) // 만약 인스턴스가 없다면 하나 만들고 -> 초기상태에 인스턴스 하나 만듬
        {
            GameObject TempSingletonInstance = new GameObject();
            SingletonInstance = TempSingletonInstance.AddComponent<DataSingleton>();
            SingletonInstance.name = typeof(DataSingleton).ToString();

            DontDestroyOnLoad(SingletonInstance);   // 그리고 다음씬 넘어갈떄 파괴 안되는 속서 부여
        }
        return SingletonInstance;// 인스턴스가 존재하면서 그 존재하는 인스턴스를 리턴 -> 다른 스크립트에서 참조 때 이부분이 실행	
    }

    // //  데이터 저장용 싱글톤 실제 변수 생성
    public int currentCube;         // 현재 플레이어가 있는 큐브의 상대 넘버
    public int currnetPosition;     // 현재 플레이어가 있는 큐브의 절대적 위치값, 즉 구조체의 배열 순서값
    public int currentRotateSetX;   // 현재 플레이어가 있는 큐브가 X축 집합(x0, x1, x2) 중 몇 번 집합 
    public int currentRotateSetZ;   // 현재 플레이어가 있는 큐브가 X축 집합(z0, z1, z2) 중 몇 번 집합
    // 큐브 절대적 위치의 각각의 데이터 저장할 구조체 27개 생성
    public rotateCubeAbsoluteStruct[] nowRotateData = new rotateCubeAbsoluteStruct[27];
    // 큐브의 상태를 저장할 27개의 구조체 객체 생성
    public rotateCubeStatusStruct[] nowStatusData = new rotateCubeStatusStruct[27];
}

[System.Serializable]
public struct rotateCubeAbsoluteStruct
{
    public int cubeNum;             // 큐브의 상태 넘버

    // 각 큐브에서 연결된 방의 위치값들이
    // 현재 있는 큐브 값 R 을 기준으로
    // up           (R - 9) < 0  -> -1          R - 9
    // down         (R + 9) > 27 -> -1
    // left         (R % 3) == 0 -> -1
    // right        (R - 2) % 3 == 0 -> -1
    // forwrad      (R % 9) == 0 1 2 -> -1
    // back         (R % 9) == 6 7 8 -> -1
    // 음수값이 나오는 경우는 연결된 큐브가 없음
    public int upCubeNum;
    public int downCubeNum;
    public int leftCubeNum;
    public int rightCubeNum;
    public int forwardCubeNum;
    public int backCubeNum;
}
[System.Serializable]
public struct rotateCubeStatusStruct
{
    public int countRotateX;        // x축 회전 값
    public int countRotateZ;        // z축 회전 값
}