using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CtrlSpotlight : MonoBehaviour
{
    public float speed = 0.25f;
    private Renderer spotlight;
    void Start()
    {
        spotlight = GetComponent<Renderer>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            spotlight.material.SetFloat("_CenterX", spotlight.material.GetFloat("_CenterX") - speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            spotlight.material.SetFloat("_CenterX", spotlight.material.GetFloat("_CenterX") + speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            spotlight.material.SetFloat("_CenterY", spotlight.material.GetFloat("_CenterY") - speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            spotlight.material.SetFloat("_CenterY", spotlight.material.GetFloat("_CenterY") + speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.Q))
        {
            spotlight.material.SetFloat("_Radius", spotlight.material.GetFloat("_Radius") - .05f*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            spotlight.material.SetFloat("_Radius", spotlight.material.GetFloat("_Radius") + .05f*Time.deltaTime);
        }
    }
}
