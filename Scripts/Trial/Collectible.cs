using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectible : MonoBehaviour
{
    public int collectibleValue = 1; // value of collectible
    public Text scoreText; // reference to score text UI element

    private int currentScore = 0; // current score

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // check if the colliding object is the player
        {
            currentScore += collectibleValue; // increase current score by collectible value
            scoreText.text = "Score: " + currentScore.ToString(); // update score UI text
            Destroy(gameObject); // destroy collectible object
        }
    }
}
