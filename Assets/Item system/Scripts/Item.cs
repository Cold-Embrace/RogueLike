using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item")]
public class Item : ScriptableObject
{
    public enum ItemType
    {
        Weapon,
        Questitem,
        Clothes,
        UsableItem
    }
    public enum WeaponType
    {
        TwoHands,
        OneHands,
        Shiled
    }

    public string ItemName;
    public string ItemDescription;
    public Sprite ItemImage;
    public ItemType Itemtype;
    public WeaponType weaponType;   
}
