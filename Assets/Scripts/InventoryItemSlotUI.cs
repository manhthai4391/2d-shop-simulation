using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemSlotUI : ItemSlotUI
{
    [SerializeField]
    Button sellButon;

    public Button EquipButton;
    public override void SetUp(Item data)
    {
        image.sprite = data.sprite;
        priceText.text = data.resellPrice.ToString();

        sellButon.onClick.RemoveAllListeners();
        sellButon.onClick.AddListener(() => { PlayerInventory.Instance.SellItem(data); });

        EquipButton.onClick.RemoveAllListeners();
        EquipButton.onClick.AddListener(() => { PlayerInventory.Instance.playerOutfitController.EquipOutfit(data); });
    }
}
