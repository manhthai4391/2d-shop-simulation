using UnityEngine;

[CreateAssetMenu(fileName ="New Item", menuName = "Outfit Item")]
public class Item : ScriptableObject
{
    public int price;
    public int resellPrice;
    public Sprite sprite;
    public OutfitType outfitType;
    public bool isEquipped;
}

public enum OutfitType
{
    head,
    face,
    hood,
    wrist_l,
    elbow_l,
    shoulder_l,
    wrist_r,
    elbow_r,
    shoulder_r,
    torso,
    boot_l,
    leg_l,
    boot_r,
    leg_r,
    pelvis
}
