using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Item))]
public class ItemInspector : Editor
{
    public override void OnInspectorGUI()
    {
        Item curentItem = (Item) target;

        string newItemName = EditorGUILayout.TextField("Item name", curentItem.ItemName);
        curentItem.ItemName = newItemName;

        string newItemDescription = EditorGUILayout.TextField("Item description", curentItem.ItemDescription);
        curentItem.ItemDescription = newItemDescription;

        curentItem.ItemImage = (Sprite)EditorGUILayout.ObjectField(curentItem.ItemImage, typeof(Sprite), true, GUILayout.Width(100), GUILayout.Height(100));

        curentItem.Itemtype = (Item.ItemType) EditorGUILayout.EnumPopup("Item type", curentItem.Itemtype);

        if (curentItem.Itemtype == Item.ItemType.Weapon)
        {
            curentItem.weaponType = (Item.WeaponType) EditorGUILayout.EnumPopup("Weapon type", curentItem.weaponType);
        }
    }
}
