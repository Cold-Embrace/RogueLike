using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInventory : MonoBehaviour
{
    public Item[] CharacterItems;
    public InventoryPanel inventoryVisual;

    private  List<Item> inventoryItems = new List<Item>();

    private void Start()
    {
        foreach (Item item in CharacterItems)
        {
            
        }
    }

    public void AddItem(Item item)
    {
        inventoryItems.Add(item);
        inventoryVisual.AddItem(item);
    }
}
