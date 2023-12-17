using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Can_be_controlled : MonoBehaviour
{
    Rigidbody2D rb2d; //kinematic body
    Vector2 dir;
    public float speed;
    bool isMoving;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dir = Vector2.zero;
        isMoving = false;
        // get input
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            isMoving = true;
            dir += Vector2.up;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.RightArrow))
        {
            isMoving = true;
            dir += Vector2.left;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            isMoving = true;
            dir += Vector2.down;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.LeftArrow))
        {
            isMoving = true;
            dir += Vector2.right;
        }
        dir.Normalize();
    }

    private void FixedUpdate()
    {
        if (isMoving)
        {
            //print(dir);
            rb2d.MovePosition(rb2d.position + dir * speed * Time.fixedDeltaTime);
        }
    }
}
