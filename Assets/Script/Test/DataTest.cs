using UnityEngine;
using System.Collections;

public class DataTest : MonoBehaviour
{
    int isGameStart;
    int[] cubeNum = new int[27];

    void SetDa()
    {
        PlayerPrefs.SetInt("Cube", 1);
    }
    // Use this for initialization
    void Start()
    {
        isGameStart = PlayerPrefs.GetInt("IsGameStrat");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(isGameStart);
    }
}
