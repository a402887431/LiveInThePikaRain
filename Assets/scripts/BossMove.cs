using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour {
    public float speed = 2f;
    public GameObject dian;

	// Use this for initialization
	void Start () {
		if(this.transform .position.y>23.85)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y < -40f||transform .position .x>40f||transform .position .x<-40f)
            Destroy(this.gameObject);
    }
}
