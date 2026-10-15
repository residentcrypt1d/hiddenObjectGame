using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;


[RequireComponent(typeof(AudioSource))] // will add one of these to the thing the script is attached to
public class MouseInteract : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler // allows us to manage pointer enter information
{
    Color s_MouseOverColor = Color.softGreen;
    Color s_OriginalColor;
    SpriteRenderer s_Renderer;
    
    public TMP_Text scoreText;
    private int score;

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
        Destroy(gameObject);
        score++;
        scoreText.text = score.ToString();
    }
}