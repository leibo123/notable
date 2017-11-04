using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCleanUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        if (other.gameObject.CompareTag("PickUp"))
        {
            //the object getting wrecked is the lil bullet
            //yea, so can I not make it be self-referential lol, it already checks the object in the if right?
            //the wall?
            //not exactly, it's a collider
            // Yea ooooo
            GameObject.Destroy(other.gameObject);
        }
    }
}
