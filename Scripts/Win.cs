using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject barrier;
    public AudioSource alsobreakk;
    public AudioClip breakk;
    void win() 
    {
        Destroy(barrier);
        alsobreakk.PlayOneShot(breakk);
    }
}
