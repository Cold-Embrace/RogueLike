using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInventory : MonoBehaviour
{
    public Item[] InitialCharacterItems;
    public InventoryPanel inventoryVisual;

    private  List<Item> inventoryItems = new List<Item>();

    private void Start()
    {
        foreach (Item item in InitialCharacterItems)
        {
            AddItem(item);
        }
    }

    public void AddItem(Item item)
    {
        inventoryItems.Add(item);
        inventoryVisual.AddItem(item);
    }
}
