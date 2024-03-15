using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public float moveSpeed = 5f;
    //public float rotateSpeed = 100f;

     void Start()
     {
        rb = GetComponent<Rigidbody2D>();
        
     }


    // Update is called once per frame
    void Update()
    {
        // transform.Translate(Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime, 0f, 0f);
        //transform.Translate(0f, Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, 0f);

        if (Input.GetKey("w"))
        {
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }


        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, rb.velocity.y);
        
        if (rb.velocity.x > 0)
        {
            sr.flipX = false;
        }
        if (rb.velocity.x < 0)
        {
            sr.flipX = true;   
        }
    }
}
