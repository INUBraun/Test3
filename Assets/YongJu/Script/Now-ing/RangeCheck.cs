using UnityEngine;
using System.Collections;

public class RangeCheck : MonoBehaviour
{
    //케릭터가 회전키를 사용할 수 있는 범위 안에 있는지 판단
    bool isRangeIN = false;
    public GameObject cubeInPlayer;

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        cubeInPlayer = hit.transform.parent.parent.gameObject;
    }

    public bool GetIsRange()
    {
        return isRangeIN;
    }

    void Update()
    {
        if (cubeInPlayer != null)
        {
            if (cubeInPlayer.transform.position.x + 6 < this.transform.position.x)
                isRangeIN = true;
            else if (cubeInPlayer.transform.position.x - 6 > this.transform.position.x)
                isRangeIN = true;
            else if (cubeInPlayer.transform.position.z + 6 < this.transform.position.z)
                isRangeIN = true;
            else if (cubeInPlayer.transform.position.z - 6 > this.transform.position.z)
                isRangeIN = true;
            else
                isRangeIN = false;
        }
    }
}
