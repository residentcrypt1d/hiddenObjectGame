using UnityEngine.InputSystem;
using TMPro;
using UnityEngine;

public class ClickInteraction : MonoBehaviour
{
    public Vector3 velocity;
    public Rigidbody2D myBody;

    public TMP_Text scoreText;
    private int score;
    private InputAction leftClick;
    
    void Start()
    {
        leftClick = InputSystem.actions.FindAction("LeftClick"); //connect input action to setting
    }
    
    void Update()
    {
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (leftClick.WasPressedThisFrame() && gameObject.CompareTag("HiddenObject"))
        {
            score++;
            scoreText.text = score.ToString();
            Destroy(gameObject);
        }
    }
}