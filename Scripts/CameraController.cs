using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform ManPlayer;
   

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(ManPlayer.position.x, ManPlayer.position.y, transform.position.z);
    }
}
