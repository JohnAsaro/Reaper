using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionGoodLvl1 : MonoBehaviour
{
    //destroys old man when trophy collides with it
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("man"))
        {
            SceneManager.LoadScene("Level 2");
            CompleteLevel();
        }
    }
    private void CompleteLevel()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
