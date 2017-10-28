using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletMovement : MonoBehaviour
{
    public float speed = 10.0f;
    

    //   private Transform bulletTransform;
    private Vector3 boosted;

    void Start()
    {
        //GameObject playerMe = new GameObject();
        GameObject playerMe = GameObject.Find("Player");
        Transform playerTransform = playerMe.transform;

        boosted = new Vector3(playerTransform.position.x, playerTransform.position.y, playerTransform.position.z);
        boosted.x -= transform.position.x;
        boosted.y -= transform.position.y;
        boosted.z -= transform.position.z;
        //boostedes = boosted;
        
    }


    void Update()
    {
        
        transform.position += boosted.normalized * speed * Time.deltaTime;
        //transform.Translate(Vector3.forward * speed * Time.deltaTime);
        //transform.position += Vector3.right * speed * Time.deltaTime;
    }
}

