using UnityEngine;

public class Banishment : MonoBehaviour

{
    Color s_MouseOverColor = Color.softRed;
    Color s_OriginalColor;
    SpriteRenderer s_Renderer;
    

    void Start()
    {
        //Fetch the sprite renderer component from the GameObject
        s_Renderer = GetComponent<SpriteRenderer>();
        //Fetch the original color of the GameObject
        s_OriginalColor = s_Renderer.material.color;
    }


    void OnMouseOver() //object changes color when hovered over INT HEORY???
    {
        //GetComponent<Image>().color -= new Color(0f, 0f, 0f, 1f);
        Debug.Log("Mouse is over GameObject.");
        s_Renderer.material.color = s_MouseOverColor;
    }

    void OnMouseExit() //this changes the tint back to normal!
    {
        //GetComponent<Image>().color += new Color(0f, 0f, 0f, 1f);
        Debug.Log("Mouse is no longer on GameObject.");
        s_Renderer.material.color = s_OriginalColor;
    }
    
    void OnMouseDown() //this makes the object tagged "HiddenObject" get destroyed on click!
    {
        if (gameObject.CompareTag("HiddenObject"))
        {
            GameObject[] HiddenObject;
            HiddenObject = GameObject.FindGameObjectsWithTag("HiddenObject");
            foreach (var i in HiddenObject)

                Destroy(i);
        }
        if (gameObject.CompareTag("HiddenObject"))
        {
            Destroy(gameObject);
            // Destroy(gameObject.tag("HiddenObject"));

        }

    }
}