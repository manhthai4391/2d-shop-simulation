using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsContainerUI : MonoBehaviour
{
    public GameObject itemSlotPrefab;

    public GameObject itemSlotParent;

    Dictionary<Item, GameObject> itemSlotList = new Dictionary<Item, GameObject>();

    public void InitializeItems(Item[] items)
    {
        foreach (Item item in items)
        {
            GameObject itemSlot = Instantiate(itemSlotPrefab, itemSlotParent.transform);
            itemSlot.GetComponent<ItemSlotUI>().SetUp(item);
            itemSlotList.Add(item, itemSlot);
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
