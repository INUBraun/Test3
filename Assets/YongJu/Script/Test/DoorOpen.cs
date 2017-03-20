using UnityEngine;
using System.Collections;

public class DoorOpen : MonoBehaviour
{
    bool bDoorOpen = false;
    float addTime = 0.0f;

    Vector3 firstPosition;
    Vector3 chDoorPosition;

    bool moveCheck = false;

    void Start()
    {
        firstPosition = this.transform.position;
        chDoorPosition = this.transform.position;
    }

    void Update()
    {
        if (bDoorOpen)
        {
            addTime += Time.deltaTime;
            if (gameObject.name.Contains("Left"))
            {
                chDoorPosition.z += addTime;
                if (Mathf.Abs(firstPosition.z - chDoorPosition.z) > 5)
                {
                    moveCheck = true;
                }
            }
            else
            {
                chDoorPosition.y += addTime;
                if (Mathf.Abs(firstPosition.y - chDoorPosition.y) > 5)
                {
                    moveCheck = true;
                }
            }

            if (moveCheck)
            {
                bDoorOpen = false;
            }
            else
            {
                this.transform.position = chDoorPosition;
            }

        }
    }

    public void DoorOpenByHit()
    {
        bDoorOpen = true;
    }

}
