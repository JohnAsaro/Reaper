using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCounter : MonoBehaviour
{
    public float timeLeft = 60.0f;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(timeLeft / 60);
        int seconds = Mathf.FloorToInt(timeLeft % 60);
        GetComponent<TMPro.TextMeshProUGUI>().text = "Time Left: " + string.Format("{0:00}:{1:00}", minutes, seconds);

        if (timeLeft <= 0)
        {
            RestartGame();
        }
    }

    void RestartGame()
    {
        // Reset any necessary variables or game objects here
        // ...

        // Reload the current scene to restart the game
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }

}
