using UnityEngine;
using System.Collections;

public class CloseCheckCharacterToDoor : MonoBehaviour
{   
    // 이 스크립트는 메인카메라에 붙여야 정상 작동하는 스크립트!!
    // 길이 1의 레이케스러를 발사하여 레이케스터에 닿은 부분의 법선 벡터를 받아온다
    // 받아온 법선벡터를 이용하여 큐브를 어떤 좌표를 기준으로 회전시켜야하는지 확인

    Vector3 normalSurface;      // 구한 법선벡터를 저장
    Vector3 rotateVector;

    bool rayHitDoor = false;

    public Vector3 GetRotateVector()
    {
        return rotateVector;
    }

    public bool GetIsRayHIt()
    {
        return rayHitDoor;
    }

    void Update()
    {
        // DrawRay
        Debug.DrawRay(transform.position, transform.forward * 1, Color.red);

        // Raycast
        RaycastHit hit;

        rayHitDoor = Physics.Raycast(transform.position, transform.forward, out hit, 1);
        if (rayHitDoor)
        {
            normalSurface = hit.normal;

            // x, y 비교 할 때, 정수값인 1과 -1로 비교를 하려 하였으나
            // 왜인지는 모르게 짝수 횟수에서 벽에 닿았을 경우
            // 얻어낸 normal 벡터값이 이상값으로 나와서
            // 정수값으로 판단할 경우, else 의 경우로 들어가 
            // 회전 벡터값이 변경되지 않음
            // 때문에 0 이 아닐 경우, 1 혹은 -1 이므로 크기 비교로 변경
            if (normalSurface.x > 0)
            {
                rotateVector = Vector3.forward;// 0 0 1
            }
            else if (normalSurface.x < 0)
            {
                rotateVector = Vector3.back;// 0 0 -1
            }
            else if (normalSurface.z > 0)
            {
                rotateVector = Vector3.left;// -1 0 0
            }
            else if (normalSurface.z < 0)
            {
                rotateVector = Vector3.right;// 1 0 0 
            }
           
           //Debug.Log(normalSurface + "===" + rotateVector);

        }
    }
}
