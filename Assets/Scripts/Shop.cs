using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class Shop : MonoBehaviour
{
    public static Shop Instance;

    public List<Item> items;

    [SerializeField]
    ItemsContainerUI itemsContainer;

    public GameObject notEnoughGoldIndicator;

    public TextMeshProUGUI customerGoldText;

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
        if (items == null)
            return;
        itemsContainer.InitializeItems(items.ToArray());
    }


    private void OnEnable()
    {
        customerGoldText.text = PlayerInventory.Instance.coins.ToString();
    }

    public void CustomerSellItem(Item item)
    {
        items.Add(item);
        itemsContainer.EnableItemSlot(item);
        customerGoldText.text = PlayerInventory.Instance.coins.ToString();
    }

    public void BuyItem(Item item)
    {
        if(PlayerInventory.Instance.CanAfford(item))
        {
            //remove item from shelf
            itemsContainer.DisableItemSlot(item);
            items.Remove(item);
            customerGoldText.text = PlayerInventory.Instance.coins.ToString();
        }
        else
        {
            //show warning
            notEnoughGoldIndicator.SetActive(true);
        }
    }
}
