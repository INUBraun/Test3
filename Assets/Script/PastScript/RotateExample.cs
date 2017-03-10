using UnityEngine;
using System.Collections;

public class RotateExample : MonoBehaviour
{
    float countEuler = 0.0f;
    Quaternion target;
    void Start()
    {
        // 트랜스폼의 rotation 값 초기화 
        transform.eulerAngles = new Vector3(0.0f, 0.0f, 0.0f);

        // 트랜스폼의 rotation 값 
        // rotaion은 Quaternion 값으로 대입해 주어야 한다.
        Quaternion target = Quaternion.Euler(0.0f, 90.0f, 0.0f);
        transform.rotation = target;

       
    }

    void Update()
    {
        countEuler += 90.0f * Time.deltaTime * 0.5f;
        if (countEuler < 90.0f)
        {
            target = Quaternion.Euler(0.0f, countEuler, 0.0f);
            transform.rotation = target;
        }
        else
        {
            target = Quaternion.Euler(0.0f, 90.0f, 0.0f);
            transform.rotation = target;
        }
       
    }
}
