using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ctrl_Light : MonoBehaviour {

    // Use this for initialization
    public float speed = 50f;
    public Light lt;
	void Start () {
        lt = GetComponent<Light>();
	}
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            lt.spotAngle-= Time.deltaTime * speed/2;
        }
        if (Input.GetKey(KeyCode.E))
        {
            lt.spotAngle += Time.deltaTime * speed/2;
        }
    }
}
