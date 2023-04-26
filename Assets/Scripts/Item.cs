using UnityEngine;

[CreateAssetMenu(fileName ="New Item", menuName = "Hat Item")]
public class Item : ScriptableObject
{
    public int price;
    public int resellPrice;
    public Sprite sprite;
}
