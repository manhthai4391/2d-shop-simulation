using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class OutfitPair
{
    public string Tag;
    public SpriteRenderer spriteRenderer;
}

public class PlayerOutfitController : MonoBehaviour
{
    [SerializeField]
    OutfitPair[] outfitPairs;

    public Dictionary<string, SpriteRenderer> outfitHashMap = new Dictionary<string, SpriteRenderer>();

    Dictionary<string, Sprite> defaultOutfits = new Dictionary<string, Sprite>();

    // Start is called before the first frame update
    void Start()
    {
        foreach (var pair in outfitPairs)
        {
            outfitHashMap.Add(pair.Tag, pair.spriteRenderer);
            defaultOutfits.Add(pair.Tag, pair.spriteRenderer.sprite);
        }
    }

    public void EquipOutfit(Item outfit)
    { 
        if(outfitHashMap.ContainsKey(outfit.outfitType.ToString()))
        {
            outfitHashMap[outfit.outfitType.ToString()].sprite = outfit.sprite;
            outfit.isEquipped = true;
        }
    }

    public void UnequipOutfit(Item outfit)
    {
        outfitHashMap[outfit.outfitType.ToString()].sprite = defaultOutfits[outfit.outfitType.ToString()];
    }
}
