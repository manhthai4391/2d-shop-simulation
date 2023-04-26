using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class Shop : MonoBehaviour
{
    public IShopCustomer customer;

    public List<Item> items;

    public GameObject itemSlotPrefab;

    public GameObject itemSlotParent;

    public GameObject notEnoughGoldIndicator;

    public TextMeshProUGUI customerGoldText;

    private void Start()
    {
        if (items == null)
            return;
        DisplayItems();
    }

    public void DisplayItems()
    {
        foreach (Item item in items)
        {
            GameObject itemSlot = Instantiate(itemSlotPrefab, itemSlotParent.transform);
            itemSlot.GetComponent<ItemSlotUI>().SetUp(item, this);
        }
    }

    private void OnEnable()
    {
        if (customer != null)
            customerGoldText.text = customer.GetCurrentGold().ToString();
    }

    public void CustomerBuyItem(Item item)
    {
        if(customer.BuyItem(item))
        {
            //remove item from shelf
            int index = items.IndexOf(item);
            Destroy(itemSlotParent.transform.GetChild(index).gameObject);
            items.Remove(item);
            customerGoldText.text = customer.GetCurrentGold().ToString();
        }
        else
        {
            //show warning
            notEnoughGoldIndicator.SetActive(true);
        }
    }
}
