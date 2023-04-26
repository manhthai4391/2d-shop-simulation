using UnityEngine;

public class ShopTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject shopUI;

    [SerializeField]
    string playerTag = "Player";

    public Shop shop;

    private bool isOn = false;

    void ShowUI(bool shouldShow)
    {
        shopUI.SetActive(shouldShow);
        isOn = shouldShow;
    }
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (shopUI == null || !collision.CompareTag(playerTag))
            return;
        shop.customer = collision.GetComponent<IShopCustomer>();
        ShowUI(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (shopUI == null || !collision.CompareTag(playerTag))
            return;
        ShowUI(false);
    }
}
