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

    // //  데이터 저장용 싱글톤 실제 객체 생성
    public int currentCube;
    public int currnetPosition;
    public rotateCubeStruct[] nowRotateData = new rotateCubeStruct[27]; // 큐브 각각의 데이터 저장할 구조체 27개 생성
    public rotateCubeStruct[][] nowRotateSetX = new rotateCubeStruct[3][];
    public rotateCubeStruct[][] nowRotateSetZ = new rotateCubeStruct[3][];
}

[System.Serializable]
public struct rotateCubeStruct
{
    public int cubeNum;
    public int countRotateX;
    public int countRotateZ;

    public int upCubeNum;
    public int downCubeNum;
    public int leftCubeNum;
    public int rightCubeNum;
    public int forwardCubeNum;
    public int backCubeNum;
    // 각 큐브에서 연결된 방의 위치값들이
    // 현재 있는 큐브 값 R 을 기준으로
    // up           (R - 9) < 0  -> -1          R - 9
    // down         (R + 9) > 27 -> -1
    // left         (R % 3) == 0 -> -1
    // right        (R - 2) % 3 == 0 -> -1
    // forwrad      (R % 9) == 0 1 2 -> -1
    // back         (R % 9) == 6 7 8 -> -1
    // 음수값이 나오는 경우는 연결된 큐브가 없음
}
