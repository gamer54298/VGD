using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed;
    public float jumpforce;
    private float moveInput;

    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
		
	}

    // Update is called once per frame
    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizantal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }
}
