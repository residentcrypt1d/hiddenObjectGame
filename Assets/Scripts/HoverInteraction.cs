using UnityEngine;
using UnityEngine.EventSystems;

public class HoverInteraction : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData p)
    {
        Debug.Log($"Entered {gameObject.name}. Yippee!!");
    }

    public void OnPointerExit(PointerEventData p)
    {
        Debug.Log($"Exited {gameObject.name}. Wahoo!!");
        Destroy(gameObject);
    }
}