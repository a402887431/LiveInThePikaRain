using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGmove : MonoBehaviour {
    public float moveSpeed = 0.1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        if (transform.position.y <= -11.1f)
            transform.position = new Vector3(transform.position.x, transform.position.y + 11.1f * 2, transform.position.z);
    }
}
