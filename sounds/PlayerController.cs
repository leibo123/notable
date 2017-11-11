using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    
    public float speed;
    public Text HealthText;
    public Text loseText;
    public int health;

    private AudioSource walking;
    private AudioSource pickupsound;
    private AudioSource deathsound;
    private Rigidbody2D rb2d;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
        //health = 0;
        loseText.text = "";
        SetCountText ();
        // importing multiple audio sources using an array
        var aSources = GetComponents<AudioSource>();
        walking = aSources[0];
        pickupsound = aSources[1];
        deathsound = aSources[2];
    }

    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement * speed);

    }

    void Update()
    {
        // walking sounds
        if (Input.GetButton("Vertical") || Input.GetButton("Horizontal"))
        {
            if (!walking.isPlaying)
            {
                walking.Play();
            }
        }
        else
        {
            walking.Stop();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // pickup detection and destruction : could adapt to bullets
        if (other.gameObject.CompareTag("PickUp"))
        {

            other.gameObject.SetActive(false);
            health = health + -1;
            SetCountText();
            pickupsound.Play();
        }
    }

    void SetCountText()
    {
        // health meter : adapted from the count field in UFO Tutorial
        HealthText.text = "Health: " + health.ToString();
        if(health <= 0)
        {
            loseText.text = "You died :/";
            deathsound.Play();
        }
    }
}