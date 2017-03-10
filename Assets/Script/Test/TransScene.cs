using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TransScene : MonoBehaviour
{
    public void SceneTrans()
    {
        // 파라미터 값(씬 이름)으로 지정한 씬 으로 전환 
        //Application.LoadLevel("ForwardCube");
        SceneManager.LoadScene("ForwardCube");
    }
}
