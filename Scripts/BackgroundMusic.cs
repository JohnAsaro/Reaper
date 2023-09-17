using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BackgroundMusic : MonoBehaviour
{
    void Awake()
    {
        // Set up the background music object
        GameObject musicObject = GameObject.Find("BackgroundMusic");
        if (musicObject == null)
        {
            musicObject = Instantiate(Resources.Load("Prefabs/BackgroundMusic")) as GameObject;
            musicObject.name = "BackgroundMusic";
            DontDestroyOnLoad(musicObject);
        }
    }
    //This is a comment
}
