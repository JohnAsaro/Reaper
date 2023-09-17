using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.InputSystem;

public class touchdebug : MonoBehaviour
{

    // Start is called before the first frame update
    void Awake()
    {
        TouchSimulation.Enable();

   ///    PlayerInput.SwitchCurrentControlScheme(InputSystem.devices.First(d => d == Touchscreen.current));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
