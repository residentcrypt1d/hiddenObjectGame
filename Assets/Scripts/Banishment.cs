using UnityEngine;

public class Banishment : MonoBehaviour

{
    Color s_MouseOverColor = Color.softGreen;
    Color s_OriginalColor;
    SpriteRenderer s_Renderer;

    void Start()
    {
        s_Renderer = GetComponent<SpriteRenderer>(); //grab sprite rendered component from object
        s_OriginalColor = s_Renderer.material.color; //grab og color of object
    }


    void OnMouseOver() //these objects are green for an amazing reason
    {
        Debug.Log("Mouse is over GameObject.");
        s_Renderer.material.color = s_MouseOverColor;
    }

    void OnMouseExit() //colors go back to normal
    {
        Debug.Log("Mouse is no longer on GameObject.");
        s_Renderer.material.color = s_OriginalColor;
    }
    
    void OnMouseDown() //objects tagged correct will explode and die
    {
        if (gameObject.CompareTag("Correct"))
        {
            Destroy(gameObject);
        }
    }
}