using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{

    public string Level1;
    public string Level2;
    public string Level3;
    //public string Level4;

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }


    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level 2");
    }


    public void LoadLevel3()
    {
        SceneManager.LoadScene("Level 3");
    }
}
