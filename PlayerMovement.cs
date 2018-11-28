using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed;
    public float jumpforce;
    private float moveInput;

    private bool Isgrounded;
    public Transform groundCheck;
    public float Checkradius;
    public LayerMask WhatIsGround;


    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
		
	}

    // Update is called once per frame
    void Update()
    {
        Isgrounded = Physics2D.OverlapCircle(groundCheck.position, Checkradius, WhatIsGround);

        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        moveInput = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.x);
    }
}
