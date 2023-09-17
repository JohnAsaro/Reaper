using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temptp : MonoBehaviour
{
    public GameObject reaper;
    public AudioClip teleport;
    public AudioSource reaperalso;
    private Boolean tpd = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (tpd == false)
        {
            reaper.transform.position = new Vector2(33.07f, 8f);
            reaperalso.PlayOneShot(teleport);
            tpd = true;
        }
    }
}
