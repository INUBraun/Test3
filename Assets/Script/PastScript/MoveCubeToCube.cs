using UnityEngine;
using System.Collections;

public class MoveCubeToCube : MonoBehaviour
{
    bool isRangeIN = false;
    GameObject cubeInPlayer;

    bool readyMove = false;
    int moveXaxis = 0;
    int moveYaxis = 0;
    int moveZaxis = 0;

    Vector3 basePosition;
    Vector3 movePosition;


    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        cubeInPlayer = hit.transform.parent.gameObject;
        basePosition = cubeInPlayer.transform.position;

        if (readyMove == false)
        {
            readyMove = true;
            if ((hit.normal.z == 1) || (hit.normal.z == -1))
            {
                if (hit.normal.z == 1)
                    moveZaxis = -1;
                else if (hit.normal.z == -1)
                    moveZaxis = 1;
            }

            if ((hit.normal.x == 1) || (hit.normal.x == -1))
            {
                if (hit.normal.x == 1)
                    moveXaxis = -1;
                else if (hit.normal.x == -1)
                    moveXaxis = 1;
            }
        }
    }

    void CheckPlayerInCube()
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

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            if (readyMove == true)
            {
                if(moveXaxis == 1)
                {
                    movePosition = basePosition;
                    movePosition.x += 15;
                    this.transform.position = movePosition;
                }
                else if (moveXaxis == -1)
                {
                    movePosition = basePosition;
                    movePosition.x -= 15;
                    this.transform.position = movePosition;
                }

                if (moveZaxis == 1)
                {
                    movePosition = basePosition;
                    movePosition.z += 15;
                    this.transform.position = movePosition;
                }
                else if (moveZaxis == -1)
                {
                    movePosition = basePosition;
                    movePosition.z -= 15;
                    this.transform.position = movePosition;
                }
            }
        }
    }
}