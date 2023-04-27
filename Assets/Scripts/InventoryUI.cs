using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventoryItemSlotPrefab;

    public GameObject inventoryItemTransformParent;

    Dictionary<Item, GameObject> itemSlotList = new Dictionary<Item, GameObject>();

    private void Start()
    {
        InitializeItemsThenDisableIt(Shop.Instance.items.ToArray());
    }

    public void InitializeItemsThenDisableIt(Item[] items)
    {
        foreach (Item item in items)
        {
            GameObject itemSlot = Instantiate(inventoryItemSlotPrefab, inventoryItemTransformParent.transform);
            itemSlot.GetComponent<ItemSlotUI>().SetUp(item);
            itemSlotList.Add(item, itemSlot);
            itemSlot.SetActive(false);
        }
    }

    public void DisableItemSlot(Item item)
    {
        itemSlotList[item].SetActive(false);
    }

    public void EnableItemSlot(Item item)
    {
        itemSlotList[item].SetActive(true);
    }
}
