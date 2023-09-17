using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameMaster : MonoBehaviour
{
    public bool runningTimer;
    public float currentTime;
    public float maxTime = 10;
    public TextMeshProUGUI timerText;

    //public Button retryButton;
    //public Button quitButton;

    // Start is called before the first frame update
    void Start()
    {
        // Find the TimerText object by name and assign it to the timerText variable
        timerText = GameObject.Find("TimerText").GetComponent<TextMeshProUGUI>();

        // Find the retry and quit buttons and assign them to variables
        //retryButton = GameObject.Find("RetryButton").GetComponent<Button>();
        //quitButton = GameObject.Find("QuitButton").GetComponent<Button>();

        // Add event listeners to the retry and quit buttons
        //retryButton.onClick.AddListener(RetryGame);
        //quitButton.onClick.AddListener(QuitGame);

        currentTime = maxTime;
        runningTimer = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (runningTimer)
        {
            currentTime -= Time.deltaTime;
            if (currentTime <= 0)
            {
                runningTimer = false;
                SceneManager.LoadScene("GameOverScene");
            }
        }

        // Update the timer text with the current time
        timerText.text = "Time: " + currentTime.ToString("00.00");
    }

    /*// Reload the gameplay scene
    public void RetryGame()
    {
        SceneManager.LoadScene("GameplayScene");
    }

    // Quit the game
    public void QuitGame()
    {
        Application.Quit();
    }*/
}
