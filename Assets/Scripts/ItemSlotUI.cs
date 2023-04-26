using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class ItemSlotUI : MonoBehaviour
{
    public Image image;
    public TextMeshProUGUI priceText;

    public void SetUp(Item data, Shop shop)
    {
        image.sprite = data.sprite;
        priceText.text = data.price.ToString();
        Button button = GetComponent<Button>();
        button.onClick.RemoveAllListeners();
        button.onClick.AddListener(() => shop.CustomerBuyItem(data));
    }
}
