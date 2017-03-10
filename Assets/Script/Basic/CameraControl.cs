using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour
{
    public float sensitivity = 700.0f;
    float rotationX;
    float rotationY;

    void Update()// 유니티가 약속한 함수, 매 프레임마다 한번씩 호출하도록 약속, 대다수의 입력을 수행
    {
        float mouseMoveValueX = Input.GetAxis("Mouse X");
        float mouseMoveValueY = Input.GetAxis("Mouse Y");
      //  Debug.Log(mouseMoveValueX + "===" + mouseMoveValueY);
        rotationY += mouseMoveValueX * sensitivity * Time.deltaTime;
        rotationX += mouseMoveValueY * sensitivity * Time.deltaTime;

        rotationX %= 360;
        rotationY %= 360;

        rotationX = Mathf.Clamp(rotationX, -90.0f, 90.0f);

        transform.eulerAngles = new Vector3(-rotationX, rotationY, 0.0f);
    }
}
