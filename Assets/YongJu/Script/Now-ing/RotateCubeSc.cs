using UnityEngine;
using System.Collections;

public class RotateCubeSc : MonoBehaviour
{
    RotateManager manager;
    DataRenewal dataRenew;

    bool isRotate = false;
    Vector3 rotateVector;

    float countEuler = 0.0f;
    Quaternion target;

    Transform cubeObject;

    float countRotateX = 0.0f;
    float countRotateZ = 0.0f;
    bool isRotateX = false;
    bool isRotateZ = false;

    void Start()
    {
        cubeObject = transform.Find("/CubeMapRE");
        dataRenew = transform.Find("/DataManager").GetComponent<DataRenewal>();
        manager = GetComponent<RotateManager>();
    }

    void Update()
    {
        isRotate = manager.GetIsRotateGo();

        if (isRotate)
        {
            rotateVector = manager.GetRotateVector();
            countEuler += 90.0f * Time.deltaTime * 0.5f;
            // 방향이 x인지 z인지 + 인지 - 인지 정한뒤에 회전

            if (countEuler < 90.0f)
            {         
                if (rotateVector.x == 1)
                {
                    target = Quaternion.Euler(countEuler, 0.0f, 0.0f);
                }
                else if (rotateVector.x == -1)
                {
                    target = Quaternion.Euler(-countEuler, 0.0f, 0.0f);
                }
                else if (rotateVector.z == 1)
                {
                    target = Quaternion.Euler(0.0f, 0.0f, countEuler);
                }
                else if (rotateVector.z == -1)
                {
                    target = Quaternion.Euler(0.0f, 0.0f, -countEuler);
                }
                transform.rotation = target;
            }
            else
            {
                if (rotateVector.x == 1)
                {
                    target = Quaternion.Euler(90.0f, 0.0f, 0.0f);
                    countRotateX = 90.0f;
                    isRotateX = true;
                }
                else if (rotateVector.x == -1)
                {
                    target = Quaternion.Euler(-90.0f, 0.0f, 0.0f);
                    countRotateX = -90.0f;
                    isRotateX = true;
                }
                else if (rotateVector.z == 1)
                {
                    target = Quaternion.Euler(0.0f, 0.0f, 90.0f);
                    countRotateZ = 90.0f;
                    isRotateZ = true;
                }
                else if (rotateVector.z == -1)
                {
                    target = Quaternion.Euler(0.0f, 0.0f, -90.0f);
                    countRotateZ = -90.0f;
                    isRotateZ = true;
                }
                Debug.Log(countRotateX + " === " + countRotateZ);
                transform.rotation = target;

                // 회전이 끝날때마다 데이터를 갱신
                // 회전에 관한 데이터를 넘겨서 갱신 시켜줘야함
                dataRenew.ChangeCube(isRotateX, isRotateZ, countRotateX, countRotateZ);
                // --- 이 지점에서 데이터 갱신 함수 실행

                isRotate = false;
                isRotateX = false;
                isRotateZ = false;
                manager.SetIsRotateEnd();

                rotateVector = Vector3.zero;
                countEuler = 0;
                transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
            }   
        }
    }
}
