using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CollisionBadLvl2 : MonoBehaviour
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
            if (lives == 0)
            {
                SceneManager.LoadScene("LoseScene Lvl 2");
            }
        }
    }
}