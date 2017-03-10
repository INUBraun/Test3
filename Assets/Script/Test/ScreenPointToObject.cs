using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ScreenPointToObject : MonoBehaviour
{
    Scene currentScene;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                currentScene = SceneManager.GetActiveScene();   
                         
                if (currentScene.name.Contains("MidCenter"))
                {
                    if (hit.transform.name.Contains("Forward"))
                    {
                        SceneManager.LoadScene("MidForwardCube");
                    }
                    else if (hit.transform.name.Contains("Back"))
                    {
                        SceneManager.LoadScene("MidBackCube");
                    }
                    else if (hit.transform.name.Contains("Left"))
                    {
                        SceneManager.LoadScene("MidCenterLeftCube");
                    }
                    else if (hit.transform.name.Contains("Right"))
                    {
                        SceneManager.LoadScene("MidCenterRightCube");
                    }
                    else if (hit.transform.name.Contains("Top"))
                    {
                        SceneManager.LoadScene("UpCenterCube");
                    }
                    else if (hit.transform.name.Contains("Bottom"))
                    {
                        SceneManager.LoadScene("DownCenterCube");
                    }
                }
            }
        }
    }
}
