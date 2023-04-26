using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ShopKeeper : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public UnityEvent onMouseEnter;
    public UnityEvent onMouseExit;
    public UnityEvent onClick;

    public void OnPointerClick(PointerEventData eventData)
    {
        onClick?.Invoke();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        onMouseEnter?.Invoke();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        onMouseExit?.Invoke();
    }
}
