using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI; // game over UI object
    public Transform player; // player object
    public Transform reaper; // reaper object
    public float gameOverDistance = 2f; // distance between player and reaper that triggers game over

    void Update()
    {
        float distance = Vector2.Distance(player.position, reaper.position);

        if (distance < gameOverDistance) // game over if player and reaper are too close
        {
            GameOver();
        }
    }

    void GameOver()
    {
        Time.timeScale = 0f; // pause game time
        gameOverUI.SetActive(true); // show game over UI
    }

    public void RestartGame() // called by restart button in game over UI
    {
        Time.timeScale = 1f; // resume game time
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // reload current scene
    }
}

