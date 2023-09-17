using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public AudioSource audioSource;

    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }

    public void QuitGame()
    {
            Application.Quit();
    }
}
