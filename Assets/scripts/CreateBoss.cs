using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBoss : MonoBehaviour {
    public GameObject boss;
    public float clock;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (clock > 0.8f)
        {
            clock = 0;
            Instantiate(boss, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        }
        else
        {
            clock += Time.deltaTime;
        }
	}
}
