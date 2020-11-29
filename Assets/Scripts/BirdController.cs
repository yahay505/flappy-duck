using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public Vector2 JumpForce,Gravity;
    public bool ShouldJump;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            ShouldJump=true;
            Debug.Log("jump");
        }
    }

    private void ProcessJump()
    {
        if (ShouldJump)
        {
            ShouldJump = false;
            rb2d.AddForce(JumpForce,ForceMode2D.Impulse);
        }
    }

    private void FixedUpdate()
    {
        ProcessGravity();
        ProcessJump();
    }

    private void ProcessGravity()
    {
        rb2d.AddForce(Gravity);

    }
}
