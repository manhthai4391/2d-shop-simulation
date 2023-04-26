using UnityEngine;

public class OutfitController : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    public void Equip(Item item)
    {
        spriteRenderer.sprite = item.sprite;
    }
}
