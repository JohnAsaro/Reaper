using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public float speed = 1f;
    public bool isHorizontal;
    public bool hitTrigger;
    public bool isMovingUp;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!isHorizontal)
        {
            if(isMovingUp && !hitTrigger)
            {
                rb.velocity = Vector2.up * speed;
            }

            if(!isMovingUp && !hitTrigger)
            {
                rb.velocity = Vector2.down * speed;
            }
        }

        if (isHorizontal)
        {
            if (isMovingUp && !hitTrigger)
            {
                rb.velocity = Vector2.right * speed;
            }

            if (!isMovingUp && !hitTrigger)
            {
                rb.velocity = Vector2.left * speed;
            }
        }
    }

    void Turn()
    {
        isMovingUp = !isMovingUp;
        hitTrigger = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if(other.gameObject.tag == "ElevatorTrigger")
        {
            hitTrigger = true;
            rb.velocity = Vector2.zero;
            Invoke("Turn", 5);
        }
    }
}
