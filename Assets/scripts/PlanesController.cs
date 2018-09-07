using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanesController : MonoBehaviour {
    public GameObject bitch;
    public float clock;
   
                              // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        F5();
    }

    public void F5()
    {
        if (clock >= 0.9f)
        {
            clock = 0;
            Instantiate(bitch, new Vector3(transform.position.x + Random.Range(0,24.0f), transform.position.y+1, transform.position.z), Quaternion.identity);
        }
        else
        {
            clock += Time.deltaTime;
        }
    }
}
