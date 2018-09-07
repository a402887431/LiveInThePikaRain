using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myplane : MonoBehaviour
{
    public GameObject myBullet;
    public int score = 0;
    public float clock;
    public void shoot()
    {
        if (clock >= 0.5f)
        {
            clock = 0;
            if (Input.GetKey(KeyCode.J))
            {
                Instantiate(myBullet, new Vector3(transform.position.x, transform.position.y + 1f, 0), Quaternion.identity);
            }
        }
        else
        {
            clock += Time.deltaTime;
        }
    }
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shoot();
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.up  * 5 * Time.deltaTime, Space.World);
        if (Input.GetKey(KeyCode.S) && transform.position.y > -5)
            transform.Translate(Vector3.down * 5 * Time.deltaTime, Space.World);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * 5 * Time.deltaTime, Space.World);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * 5 * Time.deltaTime, Space.World);
    }
    private void OnGUI()
    {
        GUIStyle bb = new GUIStyle();
        bb.normal.textColor = new Color(1, 1, 1);
        bb.fontSize = 40;
        GUI.Label(new Rect(10, 10, 200, 200), "分数：" + score.ToString(),bb);
    }
}
