using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class FollowMouse : MonoBehaviour

{
    private Vector2 positionTracker;
    [SerializeField] public float followSpeed = 1.0f;
    [SerializeField] public float trackingSpeed = 0.5f; // priv/pub/sealed/internal = accessor. controls what functions can access it.
    private Vector2 refPosition = Vector2.zero;

    void Start() // making the cursor invisible
    {
        Cursor.visible = false;
    }

    void MouseTime() // moving the mouse & tracking its position
    {
        positionTracker = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        transform.position = Vector2.SmoothDamp(transform.position, positionTracker, ref refPosition, trackingSpeed);
    }

    void Update()
    {
        MouseTime();
    }
}