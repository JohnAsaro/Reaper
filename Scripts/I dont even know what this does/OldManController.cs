

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldManController : MonoBehaviour
{

    // Define variables for movement
    public float speed = 5.0f;
    public float jumpForce = 8.0f;
    private float moveInput;

    // Define variables for ground checking
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    private bool isGrounded;

    // Define variables for jumping
    private int extraJumps;
    public int extraJumpsValue;

    // Define variables for animation
    private bool facingRight = true;
    private Rigidbody2D rb;
    //private Animator animator;

    void Start()
    {
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();
        //animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        // Check if the character is on the ground
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        // Get input for left and right movement
        moveInput = Input.GetAxisRaw("Horizontal");

        // Move the character left or right
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        // Flip the character sprite if needed
        if (facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if (facingRight == true && moveInput < 0)
        {
            Flip();
        }

        // Animate the character
        //animator.SetFloat("Speed", Mathf.Abs(moveInput));

        // Check if the character is jumping
        if (Input.GetKeyDown(KeyCode.Space) && extraJumps > 0)
        {
            rb.velocity = Vector2.up * jumpForce;











            extraJumps--;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && extraJumps == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            extraJumps = extraJumpsValue;
        }
    }
}

