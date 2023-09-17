using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectibleCounter : MonoBehaviour
{
    public int collectiblesCollected = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Collectible"))
        {
            collectiblesCollected++;
            GetComponent<Text>().text = "Collectibles: " + collectiblesCollected;
            Destroy(other.gameObject);
        }
    }

}

