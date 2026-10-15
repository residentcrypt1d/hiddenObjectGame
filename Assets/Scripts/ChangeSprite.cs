using UnityEngine;
using UnityEngine.EventSystems;

public class ChangeSprite : MonoBehaviour, IPointerClickHandler // allows us to manage pointer enter information
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }
        
    public void OnPointerClick(PointerEventData p) 
    {
        spriteRenderer.sprite = newSprite;
    }

}