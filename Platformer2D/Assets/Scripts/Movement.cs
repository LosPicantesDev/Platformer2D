﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private bool onTheFloor;
    Rigidbody2D rb;
    public float speed;
    public float jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (onTheFloor)
        {
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(new Vector2(1 * speed, 0));
            }
            else if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(new Vector2(-1 * speed, 0));
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                rb.AddForce(new Vector2(0, 1 * jumpForce), ForceMode2D.Impulse);
                onTheFloor = false;
            }


        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            onTheFloor = true;
        }       
    }

}
