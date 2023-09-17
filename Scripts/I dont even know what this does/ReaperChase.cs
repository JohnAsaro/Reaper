using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ReaperChase : MonoBehaviour
{
    public Transform target; // player object to chase
    public float speed = 3f; // reaper movement speed
    public float minDistance = 2f; // minimum distance to maintain from player
    public float maxDistance = 5f; // maximum distance to maintain from player

    void Update()
    {
        float distance = Vector2.Distance(transform.position, target.position);

        if (distance > maxDistance) // move closer to player if too far away
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        else if (distance < minDistance) // move farther away from player if too close
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, -speed * Time.deltaTime);
        }
    }
}

