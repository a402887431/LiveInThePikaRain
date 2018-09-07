using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DePlanesMove : MonoBehaviour {
    public float MoveSpeed = 4f;
    public GameObject myplane;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.down * 2 * Time.deltaTime, Space.World);
        if (transform.position.y < -10f)
            SceneManager.LoadScene(2);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "mybullet") 
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            GameObject.Find("myPlane").GetComponent<myplane>().score += 10;
        }
        else if(other.tag=="Player")
        {
                Destroy(this.gameObject);
                Destroy(other.gameObject);
                SceneManager.LoadScene(2);
            }
        }
    }
