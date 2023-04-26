using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOutfitController : MonoBehaviour
{
    public Dictionary<string, SpriteRenderer> outfitHashMap = new Dictionary<string, SpriteRenderer>();
    // Start is called before the first frame update
    void Start()
    {
        outfitHashMap = new Dictionary<string, SpriteRenderer> ();
        SpriteRenderer[] allOutfits = GetComponentsInChildren<SpriteRenderer>();
        foreach (SpriteRenderer outfit in allOutfits)
        {
            if(outfitHashMap.ContainsKey(GetTag(outfit.gameObject.name)))
            {
                Debug.Log(GetTag(outfit.gameObject.name));
            }
            else
            {
                outfitHashMap.Add(GetTag(outfit.gameObject.name), outfit);
            }
        }
    }

    public void EquipOutfit(Sprite outfit)
    {
        if(outfitHashMap.ContainsKey(GetTag(outfit.name)))
        {
            outfitHashMap[GetTag(outfit.name)].sprite = outfit;
        }
        else
        {
            Debug.Log("no sprite renderer with tag: " + GetTag(outfit.name));
        }
    }

    string GetTag(string name)
    {
        //this is hardcode for automation
        //since all gameobject/sprite names are like: Rogue_leg_L_01 
        //after this GetTag() it will return only leg_L
        string newString = name.Remove(name.Length - 3);
        return newString.Remove(0, 6);
    }
}
