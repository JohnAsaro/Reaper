/*using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void RetryGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}*/
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void RetryGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void RetryGameLvl2()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("GameMenu");
        /*       Debug.Log("Quit button clicked"); // Add a debug log here to help with debugging
       #if UNITY_EDITOR
                   UnityEditor.SceneManagement.EditorSceneManager.LoadScene(UnityEditor.SceneManagement.EditorSceneManager.GetActiveScene().name);
       #else
               SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       #endif*/
    }
}
