using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ShopKeeper : MonoBehaviour, IPointerClickHandler
{
    public UnityEvent onClick;

    [SerializeField]
    Physics2DRaycaster raycaster;

    [SerializeField]
    GameObject chatBubble;

    public void OnPointerClick(PointerEventData eventData)
    {
        onClick?.Invoke();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            chatBubble.SetActive(true);
            raycaster.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            chatBubble.SetActive(false);
            raycaster.enabled = false;
        }
    }
}
