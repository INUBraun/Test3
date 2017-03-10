using UnityEngine;
using System.Collections;

public class ScreenPointToDoor : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag.Equals("Door"))
                {
                    Debug.Log(hit.transform.name);
                    //DoorOpen doorOpenScript = hit.transform.GetComponent<DoorOpen>();
                    //if (doorOpenScript != null)
                   // {
                    //    doorOpenScript.DoorOpenByHit();
                   // }
                }
            }
        }
    }
}
