using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ReaperMovement : MonoBehaviour
{
    public float speed = 5f;
    public float delay = 5f;
    public float followDistance = 5f;
    public float appearTime = 2f;
    public float disappearTime = 2f;

    private Transform oldManTransform;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        oldManTransform = GameObject.FindGameObjectWithTag("OldMan").GetComponent<Transform>();
        StartCoroutine(MoveForward());
        StartCoroutine(Disappearing());
    }

    IEnumerator MoveForward()
    {
        yield return new WaitForSeconds(delay);

        while (true)
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
            yield return null;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            StartCoroutine(MoveThroughObstacle(collision.gameObject));
        }
    }

    IEnumerator MoveThroughObstacle(GameObject obstacle)
    {
        yield return new WaitForSeconds(0.5f);

        transform.position = new Vector3(obstacle.transform.position.x + 1f, transform.position.y, transform.position.z);
    }

    IEnumerator Disappearing()
    {
        Renderer renderer = GetComponent<Renderer>();

        while (true)
        {
            renderer.enabled = true;
            yield return new WaitForSeconds(appearTime);
            renderer.enabled = false;
            yield return new WaitForSeconds(disappearTime);
        }
    }

    void FixedUpdate()
    {
        if (Time.timeSinceLevelLoad > 15f)
        {
            Vector3 targetPos = new Vector3(oldManTransform.position.x - followDistance, transform.position.y, transform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.fixedDeltaTime);
        }
    }
}

