using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public Vector2 JumpForce,Gravity;
    public bool ShouldJump;
    public static GameObject Bird;
    // Start is called before the first frame update
    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Bird = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Bird == null)
        {
            Bird = this.gameObject;

        }
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
