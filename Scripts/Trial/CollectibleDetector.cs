using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleDetector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Collectible"))
        {
            // Do something when the old man collides with a collectible object
            Debug.Log("Old man collected a collectible!");
            Destroy(other.gameObject); // Destroy the collectible object
        }
    }
}

