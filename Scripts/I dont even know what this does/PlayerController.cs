using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 10f;
    public float slideSpeed = 5f;

    private Rigidbody2D rb;
    private float horizontalInput;
    private bool jumpPressed;
    private bool slidePressed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        jumpPressed = Input.GetKeyDown(KeyCode.Space);
        slidePressed = Input.GetKeyDown(KeyCode.LeftControl);
    }

    void FixedUpdate()
    {
        Vector2 movement = new Vector2(horizontalInput, 0f);
        rb.velocity = new Vector2(movement.x * speed, rb.velocity.y);

        if (jumpPressed && Mathf.Abs(rb.velocity.y) < 0.01f)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        if (slidePressed)
        {
            rb.velocity += Vector2.down * slideSpeed;
        }
    }
}
