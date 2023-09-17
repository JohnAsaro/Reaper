/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public float maxTime = 10.0f;
    private float currentTime;
    private bool runningTimer = true;
    private Text timerText;

    private void Start()
    {
        timerText = GetComponent<Text>();
        currentTime = maxTime;
    }

    private void Update()
    {
        if (runningTimer)
        {
            currentTime -= Time.deltaTime;
            timerText.text = "Time: " + currentTime.ToString("0.00");

            if (currentTime <= 0.0f)
            {
                runningTimer = false;
                SceneManager.LoadScene("GameOverScene");
            }
        }
    }

    public void PlayerWins()
    {
        runningTimer = false;
        SceneManager.LoadScene("WinScene");
    }

    public void PlayerLoses()
    {
        runningTimer = false;
        SceneManager.LoadScene("LoseScene");
    }
}

*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{
    public float maxTime = 120.0f;
    private float currentTime;
    private bool runningTimer = true;
    public Text timerText;

    private void Start()
    {
        timerText = GetComponent<Text>();
        currentTime = maxTime;
    }

    private void Update()
    {
        if (runningTimer)
        {
            currentTime -= Time.deltaTime;
            timerText.text = "Time: " + currentTime.ToString("0.00");

            if (currentTime <= 0.0f)
            {
                runningTimer = false;
                SceneManager.LoadScene("LoseScene");
            }
        }
    }

    public void PlayerWins()
    {
        runningTimer = false;
        SceneManager.LoadScene("WinScene");
    }

    public void PlayerLoses()
    {
        runningTimer = false;
        SceneManager.LoadScene("LoseScene");
    }
}


/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public float maxTime = 10.0f;
    private float currentTime;
    private bool runningTimer = true;
    private Text timerText;

    public GameObject gameOverPanel;
    public Button retryButton;
    public Button quitButton;

    private void Start()
    {
        timerText = GetComponent<Text>();
        currentTime = maxTime;

        // Get the retry and quit buttons from the game over panel
        if (gameOverPanel != null)
        {
            retryButton = gameOverPanel.transform.Find("RetryButton").GetComponent<Button>();
            quitButton = gameOverPanel.transform.Find("QuitButton").GetComponent<Button>();

            // Add event listeners to the buttons
            retryButton.onClick.AddListener(RetryLevel);
            quitButton.onClick.AddListener(QuitGame);
        }
    }

    private void Update()
    {
        if (runningTimer)
        {
            currentTime -= Time.deltaTime;
            timerText.text = "Time: " + currentTime.ToString("0.00");

            if (currentTime <= 0.0f)
            {
                runningTimer = false;
                gameOverPanel.SetActive(true); // Show the game over panel
            }
        }
    }

    public void PlayerWins()
    {
        runningTimer = false;
        SceneManager.LoadScene("WinScene");
    }

    public void PlayerLoses()
    {
        runningTimer = false;
        gameOverPanel.SetActive(true); // Show the game over panel
    }

    public void RetryLevel()
    {
        // Reload the current level
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        // Quit the game
        Application.Quit();
    }
}
*/

