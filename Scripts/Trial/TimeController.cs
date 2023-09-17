using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    public float timeLimit = 60.0f;
    private float timeLeft;
    public Text timeText;

    void Start()
    {
        timeLeft = timeLimit;
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        timeText.text = "Time Left: " + Mathf.RoundToInt(timeLeft).ToString();

        if (timeLeft <= 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        // TODO: End the game with a Game Over screen or other actions
        Debug.Log("Time's up!");
    }
}


