using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float health;
    public GameObject bullet;
    public float spawnTime = 3f;
    //public Transform[] spawnPoints;
    public Vector3 spawnValues;
    // Use this for initialization
    // yes, but why o.
    // nice people writing extendable code lol.
    // I'm steadily understanding how important good code practice is.
    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    void Spawn()
    {
        if (health <= 0f)
        {
            return;
        }
       // int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), Random.Range(-spawnValues.y, spawnValues.y), 1); 

        Instantiate(bullet, spawnPosition + transform.TransformPoint(0,0,0) , gameObject.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        //	GameObject
    }
}