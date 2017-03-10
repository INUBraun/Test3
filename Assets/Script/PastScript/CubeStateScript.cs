using UnityEngine;
using System.Collections;

public class CubeStateScript : MonoBehaviour
{
    public int rotateX = 0;
    public int rotateY = 0;
    public int rotateZ = 0;

    Transform centerTransform;
    Vector3 tmpVextor;

    public void RangeCube()
    {
        if (centerTransform.position.x - transform.position.x > 10)
            tmpVextor.x -= 15;
        else if (centerTransform.position.x - transform.position.x< -10)
            tmpVextor.x += 15;
        else
            tmpVextor.x = centerTransform.position.x;

        if (centerTransform.position.y - transform.position.y > 10)
            tmpVextor.y -= 15;
        else if (centerTransform.position.y - transform.position.y < -10)
            tmpVextor.y += 15;
        else
            tmpVextor.y = centerTransform.position.y;

        if (centerTransform.position.z - transform.position.z > 10)
            tmpVextor.z -= 15;
        else if (centerTransform.position.z - transform.position.z < -10)
            tmpVextor.z += 15;
        else
            tmpVextor.z = centerTransform.position.z;

        transform.position = tmpVextor;
        tmpVextor = Vector3.zero;
    }

    void Start()
    {
        centerTransform = transform.parent.transform;
        Debug.Log(centerTransform.position);
        tmpVextor = transform.position;
    }

    void Update()
    {

    }
}
