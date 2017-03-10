using UnityEngine;
using System.Collections;

public class csScreenPointTouch : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Fire1 check");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit; 

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("ray hit check");
                if (hit.transform.tag.Equals("Enemy"))
                {
                    Debug.Log("tag check");
                    csCubeRotate cubeScript = hit.transform.GetComponent<csCubeRotate>();
                    if(cubeScript != null)
                    {
                        cubeScript.RotateByHit();
                    }
                }
            }
        }
    }

}
