using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnGUI()

    {
        GUIStyle bb = new GUIStyle();
        bb.normal.textColor = new Color(1, 1, 1);
        bb.fontSize = 80;
        GUI.Label(new Rect(270, 384, 540,250), "得分：" + GameObject .Find ("myPlane").GetComponent <myplane >().score.ToString(),bb);
    }
}
