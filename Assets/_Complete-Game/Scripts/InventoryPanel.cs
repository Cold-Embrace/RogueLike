using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryPanel : MonoBehaviour
{
    public GameObject InventoryPanelVisual;

    public GameObject ItemVisualPrefab;

    public void InventoryButtonClicked()
    {
        InventoryPanelVisual.SetActive(!InventoryPanelVisual.activeInHierarchy);
    }

    public void AddItem(Item item)
    {
        
    }
}
