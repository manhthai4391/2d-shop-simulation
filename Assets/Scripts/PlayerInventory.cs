using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public static PlayerInventory Instance;

    public List<Item> items;

    public int coins;

    public PlayerOutfitController playerOutfitController;

    [SerializeField]
    InventoryUI inventoryUI;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        
        playerOutfitController = GetComponent<PlayerOutfitController>();
    }

    public void SellItem(Item item)
    {
        inventoryUI.DisableItemSlot(item);
        coins += item.resellPrice;
        items.Remove(item);
        if(item.isEquipped)
        {
            playerOutfitController.UnequipOutfit(item);
        }
        Shop.Instance.CustomerSellItem(item);
    }

    public bool CanAfford(Item item)
    {
        if (coins >= item.price)
        {
            items.Add(item);
            inventoryUI.EnableItemSlot(item);
            coins -= item.price;
            return true;
        }
        else return false;
    }
}
