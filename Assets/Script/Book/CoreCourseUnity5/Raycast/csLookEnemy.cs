using UnityEngine;
using System.Collections;

public class csLookEnemy : MonoBehaviour
{
    public Transform enemy;
    private Transform spPoint;

    RaycastHit hit;
    Vector3 fwd = Vector3.forward;

    void Start()
    {
        //spPoint = transform.Find("/Turret/Tower/spawnPoint");
    }

    void Update()
    {
        transform.LookAt(enemy);

        Debug.DrawRay(spPoint.position, spPoint.forward * 4, Color.red);

        if(Physics.Raycast(spPoint.position, fwd, out hit, 4))
        {
            Debug.Log(hit.collider.gameObject.name);
        }
    }
}
