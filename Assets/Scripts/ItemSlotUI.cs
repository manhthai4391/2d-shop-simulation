using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class ItemSlotUI : MonoBehaviour
{
    public Image image;
    public TextMeshProUGUI priceText;

    public virtual void SetUp(Item data)
    {
        image.sprite = data.sprite;
        priceText.text = data.price.ToString();
        Button button = GetComponent<Button>();
        button.onClick.RemoveAllListeners();
        button.onClick.AddListener(() => Shop.Instance.BuyItem(data));
    }
}
