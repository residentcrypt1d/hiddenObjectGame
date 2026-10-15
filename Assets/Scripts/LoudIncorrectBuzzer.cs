using UnityEngine;
using UnityEngine.EventSystems;


[RequireComponent(typeof(AudioSource))] // will add one of these to the thing the script is attached to
public class LoudIncorrectBuzzer : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler // allows us to manage pointer enter information
{
    Color s_MouseOverColor = Color.softRed;
    Color s_OriginalColor;
    SpriteRenderer s_Renderer;

    public AudioSource sfx;
    

    void Start()
    {
        s_Renderer = GetComponent<SpriteRenderer>(); //grab sprite rendered component from object
        s_OriginalColor = s_Renderer.material.color; //grab og color of object
    }
    
    public void OnPointerEnter(PointerEventData p)
    {
        Debug.Log($"Entered {gameObject.name}. Yippee!!");
        s_Renderer.material.color = s_MouseOverColor;
    }

    public void OnPointerExit(PointerEventData p)
    {
        Debug.Log($"Exited {gameObject.name}. Wahoo!!");
        s_Renderer.material.color = s_OriginalColor;
    }

    public void OnPointerClick(PointerEventData p)
    {
        Debug.Log($"Clicked {gameObject.name}. Whoa!!");
        sfx.Play();
    }
}