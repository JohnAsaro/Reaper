using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // player movement speed
    public float jumpForce = 10f; // player jump force

    private Rigidbody2D rb;
    private bool isGrounded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // Move the player horizontally
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        // Flip the sprite if moving left
        if (moveInput < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (moveInput > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }

        if (isGrounded && Input.GetKeyDown(KeyCode.Space)) // jump if player is on ground and space bar is pressed
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
        }

        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        if (xInput != 0 || yInput != 0) // move player in all directions if arrow keys are pressed
        {
            Vector2 moveDirection = new Vector2(xInput, yInput).normalized;
            rb.velocity = moveDirection * speed;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground") || other.gameObject.CompareTag("Obstacle"))
        {
            isGrounded = true;
        }
    }
}