/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionBad : MonoBehaviour
{

    //destroys old man when reaper collides with it
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("man"))
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        }
    }
}*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

    public class CollisionBad : MonoBehaviour
    {
    //destroys old man when reaper collides with it
    public int lives = 10;
    public GameObject OldMan;
    public AudioSource ouch;
    public AudioClip hitsound;
    public Text lifecountUI;
    public ParticleSystem hurt;


    private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("man"))
            {
            hurt.Play();
            ouch.PlayOneShot(hitsound);
            lives--;
            lifecountUI.text = lives.ToString();
            OldMan.transform.position = new Vector2(0, 0);
                if (lives < 1) { 
                 SceneManager.LoadScene("LoseScene");
                }
            }
        }
    }