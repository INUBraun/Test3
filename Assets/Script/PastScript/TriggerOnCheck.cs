using UnityEngine;
using System.Collections;

public class TriggerOnCheck : MonoBehaviour
{
    private int fade = 0; // 1 : FadeOut, -1 : FadeIn
    private float alpha = 0;
    public Texture fadeTex;

    void Start()
    {
        fadeIn();
    }
    public void fadeIn()
    {
        //Global.transit = false;
        fade = -1;
        alpha = 1.0f;
    }
    public void fadeOut()
    {
        //Global.transit = true;
        fade = 1;
        alpha = 0.0f;
    }
    void OnGUI()
    {
        Color col = GUI.color;
        col.a = alpha;
        GUI.color = col;
        GUI.depth = -1000;
        //GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeTex);
        if (Mathf.Abs(alpha - 0.5f) > 0.5f)
        {
            return;
        }
        else {
            alpha += Time.deltaTime * fade * 0.5f;
        }
    }

}
