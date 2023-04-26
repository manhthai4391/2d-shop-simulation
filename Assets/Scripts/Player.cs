using UnityEngine;

public class Player : MonoBehaviour, IShopCustomer, ICoinCollector
{
    public OutfitController outfit;

    int currentGold;

    public void Collect()
    {
        currentGold++;
    }

    public int GetCurrentGold()
    {
        return currentGold;
    }

    public bool BuyItem(Item item)
    {
        if (item.price > GetCurrentGold())
            return false;
        else
        {
            currentGold -= item.price;
            //Equip item
            outfit.Equip(item);
            return true;
        }
    }
}
