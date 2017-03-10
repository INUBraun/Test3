using UnityEngine;
using System.Collections;

public class csRaycastAll : MonoBehaviour
{
    private float speed = 5.0f;

    void Update()
    {
        // DrawRay
        Debug.DrawRay(transform.position, transform.forward * 8, Color.red);

        // Raycast
        RaycastHit[] hits;
        hits = Physics.RaycastAll(transform.position, transform.forward, 8.0f);

        for (int i = 0; i < hits.Length; i++)
        {
            RaycastHit hit = hits[i];

            //Debug.Log(hit.collider.gameObject.name);
        }
    }
}
