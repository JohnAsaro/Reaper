using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputMove : MonoBehaviour
{
    private PlayerInput playerInput;

    private InputAction touchPositionAction;
    private InputAction touchPressAction;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        touchPressAction = playerInput.actions["TouchPress"];
        touchPositionAction = playerInput.actions["TouchPosition"];
    }

    private void OnEnable()
    {
        touchPressAction.performed += TouchPressed;
    }

    private void OnDisable()
    {
        touchPressAction.performed += TouchPressed;
    }

    private void TouchPressed(InputAction.CallbackContext context) 
    {
       float value = context.ReadValue<float>();
        Debug.Log(value);
    }
}
