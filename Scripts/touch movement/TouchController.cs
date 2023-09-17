using UnityEngine;

public class TouchController : MonoBehaviour
{
    public static bool isTouching = false;
    public static Vector3 touchPosition;

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            isTouching = true;
            touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            Debug.Log(touch.position);
        }
        else
        {
            isTouching = false;
        }
    }
}