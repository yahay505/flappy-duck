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
    public int PipeSpeed;
    public Sprite[] BirdStates;
    public SpriteRenderer render;
    // Start is called before the first frame update
    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Bird = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        ProcessHeading();
        ProcessAnimation();
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
    private void ProcessHeading()
    {
        Vector2 _test = new Vector2(PipeSpeed, rb2d.velocity.y);
       float _angle = Vector2.Angle(Vector2.right, _test);
        //Debug.Log(_test);
        if (rb2d.velocity.y>0)
        {
            transform.rotation = Quaternion.Euler(0, 0, _angle);

        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, _angle*-1);

        }
    }
    void ProcessAnimation()
    {
        Debug.Log(transform.rotation.eulerAngles.z);
        if (transform.rotation.eulerAngles.z <25|| transform.rotation.eulerAngles.z > 335)
        {
            render.sprite = BirdStates[0];
        }
        else if (transform.rotation.z < 0)
        {
            render.sprite = BirdStates[1];

        }
        else
        {
            render.sprite = BirdStates[2];

        }
    }
}
