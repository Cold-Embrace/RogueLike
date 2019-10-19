using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryPanel : MonoBehaviour
{
    public GameObject InventoryPanelVisual;
    public GameObject ItemVisualPrefab;
    public Transform ItemsHub;

    public Text itemNameField, itemDesriptionField;
    public Image itemPicture;
    public void InventoryButtonClicked()
    {
        InventoryPanelVisual.SetActive(!InventoryPanelVisual.activeInHierarchy);
    }

    public void AddItem(Item item)
    {
        GameObject newItem = Instantiate(ItemVisualPrefab, Vector3.zero, Quaternion.identity, ItemsHub);
        newItem.GetComponent<ItemVisual>().Init(item);
    }



    public void ShowInfo(Item item)
    {
        itemNameField.enabled = true;
        itemDesriptionField.enabled = true;
        itemPicture.enabled = true;
        itemNameField.text = item.ItemName;
        itemDesriptionField.text = item.ItemDescription;
        itemPicture.sprite = item.ItemImage;
    }
    public void HideInfo(Item itemAsset)
    {
        itemNameField.enabled = false;
        itemDesriptionField.enabled = false;
        itemPicture.enabled = false;
    }
}