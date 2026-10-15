using UnityEngine;
using UnityEngine.InputSystem;

public class FollowMouse : MonoBehaviour
{
    private Vector2 positionTracker;
    private Vector2 refPosition = Vector2.zero;
    public float followSpeed = 1.0f;
    public float trackingSpeed = 0.3f;
    
    
    void Start()
    {
        Cursor.visible = false;
    }

    
    void Update()
    {
        positionTracker = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //FOR PRECISE FOLLOW 
        transform.position = Vector2.SmoothDamp(transform.position, positionTracker, ref refPosition, trackingSpeed);
     
    }
}