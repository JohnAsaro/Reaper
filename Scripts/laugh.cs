using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laugh : MonoBehaviour
{
    public AudioClip clip;
    private AudioSource audioSource;

    void Start()
    {
        //play evil laugh every 20 seconds
        audioSource = GetComponent<AudioSource>();
        InvokeRepeating("PlayClip", 5f, 25f);
    }

    void PlayClip()
    {
        audioSource.PlayOneShot(clip);
    }
}
