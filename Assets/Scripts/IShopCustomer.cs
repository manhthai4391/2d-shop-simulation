using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShopCustomer 
{
    int GetCurrentGold();

    bool BuyItem(Item item);
}
