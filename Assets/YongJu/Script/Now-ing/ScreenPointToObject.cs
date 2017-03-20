using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ScreenPointToObject : MonoBehaviour
{
    Scene currentScene;

    int targetCube = -1;

    public void StartGameButton()
    {
        SceneManager.LoadScene("MidCenterCube");
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                currentScene = SceneManager.GetActiveScene();

                if (!currentScene.name.Contains("Start"))
                {
                    if (hit.normal.x == 1)
                    {
                        targetCube = DataSingleton.Singleton().nowRotateData[DataSingleton.Singleton().currentCube].leftCubeNum;
                    }
                    else if (hit.normal.x == -1)
                    {
                        targetCube = DataSingleton.Singleton().nowRotateData[DataSingleton.Singleton().currentCube].rightCubeNum;
                    }
                    else if (hit.normal.y == 1)
                    {
                        targetCube = DataSingleton.Singleton().nowRotateData[DataSingleton.Singleton().currentCube].downCubeNum;
                    }
                    else if (hit.normal.y == -1)
                    {
                        targetCube = DataSingleton.Singleton().nowRotateData[DataSingleton.Singleton().currentCube].upCubeNum;
                    }
                    else if (hit.normal.z == 1)
                    {
                        targetCube = DataSingleton.Singleton().nowRotateData[DataSingleton.Singleton().currentCube].backCubeNum;
                    }
                    else if (hit.normal.z == -1)
                    {
                        targetCube = DataSingleton.Singleton().nowRotateData[DataSingleton.Singleton().currentCube].forwardCubeNum;
                    }

                    switch (targetCube)
                    {
                        case 0:
                            {
                                DataSingleton.Singleton().currentCube = 0;
                                SceneManager.LoadScene("UpForwardLeftCube");
                                break;
                            }
                        case 1:
                            {
                                DataSingleton.Singleton().currentCube = 1;
                                SceneManager.LoadScene("UpForwardCube");
                                break;
                            }
                        case 2:
                            {
                                DataSingleton.Singleton().currentCube = 2;
                                SceneManager.LoadScene("UpForwardRightCube");
                                break;
                            }
                        case 3:
                            {
                                DataSingleton.Singleton().currentCube = 3;
                                SceneManager.LoadScene("UpCenterLeftCube");
                                break;
                            }
                        case 4:
                            {
                                DataSingleton.Singleton().currentCube = 4;
                                SceneManager.LoadScene("UpCenterCube");
                                break;
                            }
                        case 5:
                            {
                                DataSingleton.Singleton().currentCube = 5;
                                SceneManager.LoadScene("UpCenterRightCube");
                                break;
                            }
                        case 6:
                            {
                                DataSingleton.Singleton().currentCube = 6;
                                SceneManager.LoadScene("UpBackLeftCube");
                                break;
                            }
                        case 7:
                            {
                                DataSingleton.Singleton().currentCube = 7;
                                SceneManager.LoadScene("UpBackCube");
                                break;
                            }
                        case 8:
                            {
                                DataSingleton.Singleton().currentCube = 8;
                                SceneManager.LoadScene("UpBackRightCube");
                                break;
                            }
                        case 9:
                            {
                                DataSingleton.Singleton().currentCube = 9;
                                SceneManager.LoadScene("MidForwardLeftCube");
                                break;
                            }
                        case 10:
                            {
                                DataSingleton.Singleton().currentCube = 10;
                                SceneManager.LoadScene("MidForwardCube");
                                break;
                            }
                        case 11:
                            {
                                DataSingleton.Singleton().currentCube = 11;
                                SceneManager.LoadScene("MidForwardRightCube");
                                break;
                            }
                        case 12:
                            {
                                DataSingleton.Singleton().currentCube = 12;
                                SceneManager.LoadScene("MidCenterLeftCube");
                                break;
                            }
                        case 13:
                            {
                                DataSingleton.Singleton().currentCube = 13;
                                SceneManager.LoadScene("MidCenterCube");
                                break;
                            }
                        case 14:
                            {
                                DataSingleton.Singleton().currentCube = 14;
                                SceneManager.LoadScene("MidCenterRightCube");
                                break;
                            }
                        case 15:
                            {
                                DataSingleton.Singleton().currentCube = 15;
                                SceneManager.LoadScene("MidBackLeftCube");
                                break;
                            }
                        case 16:
                            {
                                DataSingleton.Singleton().currentCube = 16;
                                SceneManager.LoadScene("MidBackCube");
                                break;
                            }
                        case 17:
                            {
                                DataSingleton.Singleton().currentCube = 17;
                                SceneManager.LoadScene("MidBackRightCube");
                                break;
                            }
                        case 18:
                            {
                                DataSingleton.Singleton().currentCube = 18;
                                SceneManager.LoadScene("DownForwardLeftCube");
                                break;
                            }
                        case 19:
                            {
                                DataSingleton.Singleton().currentCube = 19;
                                SceneManager.LoadScene("DownForwardCube");
                                break;
                            }
                        case 20:
                            {
                                DataSingleton.Singleton().currentCube = 20;
                                SceneManager.LoadScene("DownForwardRightCube");
                                break;
                            }
                        case 21:
                            {
                                DataSingleton.Singleton().currentCube = 21;
                                SceneManager.LoadScene("DownCenterLeftCube");
                                break;
                            }
                        case 22:
                            {
                                DataSingleton.Singleton().currentCube = 22;
                                SceneManager.LoadScene("DownCenterCube");
                                break;
                            }
                        case 23:
                            {
                                DataSingleton.Singleton().currentCube = 23;
                                SceneManager.LoadScene("DownCenterRightCube");
                                break;
                            }
                        case 24:
                            {
                                DataSingleton.Singleton().currentCube = 24;
                                SceneManager.LoadScene("DownBackLeftCube");
                                break;
                            }
                        case 25:
                            {
                                DataSingleton.Singleton().currentCube = 25;
                                SceneManager.LoadScene("DownBackCube");
                                break;
                            }
                        case 26:
                            {
                                DataSingleton.Singleton().currentCube = 26;
                                SceneManager.LoadScene("DownBackRightCube");
                                break;
                            }
                        default:
                            {
                                DataSingleton.Singleton().currentCube = 13;
                                SceneManager.LoadScene("MidCenterCube");
                                break;
                            }
                    }

                    //if (targetCube == 0)
                    //{
                    //    SceneManager.LoadScene("MidForwardCube");
                    //}
                    //else if (hit.transform.name.Contains("Back"))
                    //{
                    //    SceneManager.LoadScene("MidBackCube");
                    //}
                    //else if (hit.transform.name.Contains("Left"))
                    //{
                    //    SceneManager.LoadScene("MidCenterLeftCube");
                    //}
                    //else if (hit.transform.name.Contains("Right"))
                    //{
                    //    SceneManager.LoadScene("MidCenterRightCube");
                    //}
                    //else if (hit.transform.name.Contains("Top"))
                    //{
                    //    SceneManager.LoadScene("UpCenterCube");
                    //}
                    //else if (hit.transform.name.Contains("Bottom"))
                    //{
                    //    SceneManager.LoadScene("DownCenterCube");
                    //}
                }
            }
        }
    }
}
