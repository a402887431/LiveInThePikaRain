using UnityEngine;
using System.Collections;

public class myBullet : MonoBehaviour
{
    private float bulletSpeed = 17;
    public float clock;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            transform.Translate(Vector3.up * bulletSpeed * Time.deltaTime, Space.World);
        if (transform.position.y > 40f)
            Destroy(this.gameObject);
    }
}
