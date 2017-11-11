using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ctrl : MonoBehaviour
{
    public float speed = 1.5f;
    private float temp;

    void OnTriggerEnter2D(Collider2D collision)
    {
        temp = speed;
        if (collision.tag.Equals("Spotlight"))
        {
            speed *= 2f;
            GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        speed = temp;
        GetComponent<SpriteRenderer>().color = new Color(1f, 0.5f, 0.5f);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
    }
}
