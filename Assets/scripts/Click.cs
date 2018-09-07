using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Click : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
       
    }



    public void OnClick()
    {
        SceneManager.LoadScene(1);
    }
    void OnGUI()

    {
        GUIStyle bb = new GUIStyle();
        bb.normal.textColor = new Color(1, 1, 1);
        bb.fontSize = 40;
        GUI.Label(new Rect(270, 380,400, 250), "在皮卡雨中存活下来吧！\n碰撞章鱼便会结束游戏\n章鱼下落至底部也会结束游戏哦",bb);
    }
}