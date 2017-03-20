using UnityEngine;
using System.Collections;

public class RotateManager : MonoBehaviour {

    // RotateManager 에 넣어야할 스크립트
    RangeCheck rangeScript;
    CloseCheckCharacterToDoor closeCheckScript;

    public Transform player;
    public Transform cubeObject;

    bool isRangeIN = false;
    bool isPlayerSeeDoor = false;
    Vector3 rotateVector;

    bool isRotateGo = false;

    public bool GetIsRotateGo()
    {
        return isRotateGo;
    }

    public void SetIsRotateEnd()
    {
        isRotateGo = false;
        cubeObject.transform.parent = null;
        player.transform.parent = null;
    }

    public Vector3 GetRotateVector()
    {
        return rotateVector;
    }

    void Start()
    {
        player = transform.Find("/Player");
        cubeObject = transform.Find("/CubeMapRE");
        rangeScript = player.GetComponent<RangeCheck>();
        closeCheckScript = player.GetComponentInChildren<CloseCheckCharacterToDoor>();
    }

    void Update()
    {
        isRangeIN = rangeScript.GetIsRange();
        isPlayerSeeDoor = closeCheckScript.GetIsRayHIt();

        if (!isRotateGo)
        {
            //Debug.Log(isRangeIN +"==="+isPlayerSeeDoor);
            if (isRangeIN && isPlayerSeeDoor)
            {
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    Debug.Log("buttondown");
                    rotateVector = closeCheckScript.GetRotateVector();
                    cubeObject.transform.parent = this.transform;
                    player.transform.parent = this.transform;
                    isRotateGo = true;
                }
            }
        }
    }
}
