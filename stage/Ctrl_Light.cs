using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ctrl_Light : MonoBehaviour {

    // Use this for initialization
    public float speed = 50f;
    public Light lt;
    public CircleCollider2D cc;
	void Start () {
        lt = GetComponent<Light>();
        cc = GetComponent<CircleCollider2D>();
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
        if (lt.spotAngle < 50)
        {
            cc.radius = lt.spotAngle / 5f * 2f;
        }
        else
        {
            //Range should be set to 800.
            //Position at -50
            cc.radius = -35.21286f + 2.000698f * lt.spotAngle - 0.02330947f * Mathf.Pow(lt.spotAngle, 2) + 0.0001180536f * Mathf.Pow(lt.spotAngle, 3);
            //cc.radius = 46.9837f - 1.022956f * lt.spotAngle + 0.01061152f * Mathf.Pow(lt.spotAngle, 2);
        }
        //cc.radius = -35.21286f + 2.000698f * lt.spotAngle - 0.02330947f * Mathf.Pow(lt.spotAngle, 2) + 0.0001180536f * Mathf.Pow(lt.spotAngle, 3);
      //  cc.radius = 156657704f + (13.76671f - 156657700f) / (1 + Mathf.Pow((lt.spotAngle / 7784.218f), 3.533164f));
    }
}
